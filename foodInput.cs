using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static DietSentry.UtilitiesRMG; // so can use the UnitsString function
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DietSentry
{
    public partial class FoodInputForm : Form
    {
        private FoodsContext? dbContext;

        private readonly MainForm? mainForm;

        public FoodInputForm(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
            if (mainForm!.inputType == 0)
            {
                this.Text = "Form for ADDING food";
            }
            else // if (mainForm.inputType == 1)
            {
                this.Text = "Form for EDITING food";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new FoodsContext();

            this.dbContext.Database.EnsureCreated();

            this.dbContext.Foods.Load();
            this.dbContext.Recipe.Load();

            this.foodBindingSource.DataSource = dbContext.Foods.Local.ToBindingList();
            this.recipeBindingSource.DataSource = dbContext.Recipe.Local.ToBindingList();
        }

        // deletes any provisionally created recipe or reverts to original if editing was being done
        private void CancelAdditionOfRecipe()
        {
            if ((recordID != 0) & (mainForm!.inputType == 0))
            {
                // a recipe record has been created in food record add mode 
                using var context = new FoodsContext();
                context.Foods.Load();

                // gain direct access to recipe record in the Foods table
                var recipeFood = context.Foods.Single(b => b.FoodId == recordID);

                // delete this record from Foods table
                context.Foods.Remove(recipeFood);
                context.SaveChanges();

                context.Recipe.Load();

                // delete any created records in the recipe table
                var recipeFoods = context.Recipe.Where(r => r.FoodId == recordID);
                context.Recipe.RemoveRange(recipeFoods);

                context.SaveChanges();
            }
            else if ((mainForm.foodType == 2) & (mainForm.inputType == 1))
            {
                // a selected recipe has potentialy been edited but we are cancelling, so we need to reverse any changes.
                using var context = new FoodsContext();
                context.Recipe.Load();

                // delete any 0 recipe items which represent the new edited state of the recipe
                var recipeFoods0 = context.Recipe.Where(r => ((r.FoodId == recordID) & (r.CopyFg == 0)));
                context.Recipe.RemoveRange(recipeFoods0);

                // convert all recipe items with CopyFg=1 to have CopyFg=0
                var recipeFoods1 = context.Recipe.Where(r => ((r.FoodId == recordID) & (r.CopyFg == 1)));
                foreach (var food in recipeFoods1)
                {
                    food.CopyFg = 0;
                }

                context.Foods.Load();

                // gain direct access to recipe record in the Foods table and restore its Food Description
                // it in fact it has been modified
                var recipeFood = context.Foods.Single(b => b.FoodId == recordID);
                recipeFood.FoodDescription = mainForm.fullFoodDescription;

                context.SaveChanges();
            }
        }

        // when {Add food} (or renamed) {Edit food} button is pressed
        private void ButtonAddFood_Click(object sender, EventArgs e)
        {
            bool ignoreBtn = false;

            if (mainForm!.inputType == 0)
            {
                // cleaning up form if ADDING foood item
                mainForm.actOnFoodAdded = true;

                // By this stage it is assumed that all mainForm.addedFoodItem values are assigned even if just to "" or 0F
                // this tells the code in the MainForm to actually add the recorded Food item to the Foods table
                // and what food type is being added. Sold, Liquid or Recipe
                if (radioButtonSolid.Checked)
                {
                    mainForm.foodType = 3; // solid-private
                    mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " #";
                    CancelAdditionOfRecipe();
                }
                else if (radioButtonLiquid.Checked)
                {
                    mainForm.foodType = 4; // liquid-private
                    mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " mL#";
                    CancelAdditionOfRecipe();
                }
                else // if (radioButtonRecipie.Checked)
                {
                    mainForm.foodType = 2; // recipe

                    try // crashes if no recipe components to sum
                    {
                        if (recordID != 0)  // have created a recipe 
                        {
                            // completing creation of recipe
                            using var context = new FoodsContext();
                            context.Recipe.Load();

                            // summing the component foods making up the recipe 
                            var queriedData = context.Recipe.Local.ToBindingList().GroupBy(o => o.FoodId).Select(g => new
                            {
                                FoodId = g.Key,
                                CopyFg = g.Sum(i => i.CopyFg),
                                Amount = g.Sum(i => i.Amount),
                                Energy = g.Sum(i => i.Energy),
                                Protein = g.Sum(i => i.Protein),
                                FatTotal = g.Sum(i => i.FatTotal),
                                SaturatedFat = g.Sum(i => i.SaturatedFat),
                                TransFat = g.Sum(i => i.TransFat),
                                PolyunsaturatedFat = g.Sum(i => i.PolyunsaturatedFat),
                                MonounsaturatedFat = g.Sum(i => i.MonounsaturatedFat),
                                Carbohydrate = g.Sum(i => i.Carbohydrate),
                                Sugars = g.Sum(i => i.Sugars),
                                DietaryFibre = g.Sum(i => i.DietaryFibre),
                                SodiumNa = g.Sum(i => i.SodiumNa),
                                CalciumCa = g.Sum(i => i.CalciumCa),
                                PotassiumK = g.Sum(i => i.PotassiumK),
                                ThiaminB1 = g.Sum(i => i.ThiaminB1),
                                RiboflavinB2 = g.Sum(i => i.RiboflavinB2),
                                NiacinB3 = g.Sum(i => i.NiacinB3),
                                Folate = g.Sum(i => i.Folate),
                                IronFe = g.Sum(i => i.IronFe),
                                MagnesiumMg = g.Sum(i => i.MagnesiumMg),
                                VitaminC = g.Sum(i => i.VitaminC),
                                Caffeine = g.Sum(i => i.Caffeine),
                                Cholesterol = g.Sum(i => i.Cholesterol),
                                Alcohol = g.Sum(i => i.Alcohol)
                            }).Where(x => x.FoodId == recordID).Last();

                            //textBox1.Text = string.Format("{0:N2}", queriedData.Amount);

                            // weight of recipe in grams
                            float rAmount = queriedData.Amount;

                            // scaling multiplier to convert nutrient totals to per 100g for recipe food
                            float X = 100F / rAmount;

                            // string to add to end of recipe foods description. It includes recipe weight in grams 
                            string rsAmount = " {recipe=" + string.Format("{0:N0}", rAmount) + "g} *";
                            //textBox1.Text = rsAmount;

                            // updating the recipe food details (the one with the recordID Key)
                            var editFood = context.Foods.Single(b => b.FoodId == recordID);

                            editFood.FoodDescription += rsAmount;
                            editFood.Energy = queriedData.Energy * X;
                            editFood.Protein = queriedData.Protein * X;
                            editFood.FatTotal = queriedData.FatTotal * X;
                            editFood.SaturatedFat = queriedData.SaturatedFat * X;
                            editFood.TransFat = queriedData.TransFat * X;
                            editFood.PolyunsaturatedFat = queriedData.PolyunsaturatedFat * X;
                            editFood.MonounsaturatedFat = queriedData.MonounsaturatedFat * X;
                            editFood.Carbohydrate = queriedData.Carbohydrate * X;
                            editFood.Sugars = queriedData.Sugars * X;
                            editFood.DietaryFibre = queriedData.DietaryFibre * X;
                            editFood.SodiumNa = queriedData.SodiumNa * X;
                            editFood.CalciumCa = queriedData.CalciumCa * X;
                            editFood.PotassiumK = queriedData.PotassiumK * X;
                            editFood.ThiaminB1 = queriedData.ThiaminB1 * X;
                            editFood.RiboflavinB2 = queriedData.RiboflavinB2 * X;
                            editFood.NiacinB3 = queriedData.NiacinB3 * X;
                            editFood.Folate = queriedData.Folate * X;
                            editFood.IronFe = queriedData.IronFe * X;
                            editFood.MagnesiumMg = queriedData.MagnesiumMg * X;
                            editFood.VitaminC = queriedData.VitaminC * X;
                            editFood.Caffeine = queriedData.Caffeine * X;
                            editFood.Cholesterol = queriedData.Cholesterol * X;
                            editFood.Alcohol = queriedData.Alcohol * X;

                            context.SaveChanges();
                        }
                    }
                    catch // display message that tells you that recipes must contain component foods
                    {
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "A recipe must contain component food items!";
                        string caption = "CANNOT ADD THIS RECIPE";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons);

                        // prevents continued processing
                        ignoreBtn = true;
                    }
                }
            }
            if (mainForm.inputType == 1)
            {
                // finishing processing the EDITING of a food item
                // By this stage it is assumed that all mainForm.addedFoodItem values are assigned even if just to "" or 0F

                // this tells the code in the MainForm to actually add the recorded Food item to the Foods table
                // and what food type is being added. Sold, Liquid or Recipie
                mainForm.actOnFoodAdded = true;
                switch (mainForm.foodType)
                {
                    case 0: // solid-public
                        // unchanged
                        break;
                    case 1: // liquid-public
                        mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " mL";
                        break;
                    case 2: // recipe
                        try // crashes if no recipe components to sum
                        {
                            using var context = new FoodsContext();
                            context.Recipe.Load();

                            // summing the component foods making up the recipe 
                            var qData = context.Recipe.Local.ToList().
                                Where(x => ((x.FoodId == recordID) & (x.CopyFg == 0))).
                                GroupBy(o => o.FoodId).
                                Select(g => new
                                {
                                    FoodId = g.Key,
                                    Amount = g.Sum(i => i.Amount),
                                    Energy = g.Sum(i => i.Energy),
                                    Protein = g.Sum(i => i.Protein),
                                    FatTotal = g.Sum(i => i.FatTotal),
                                    SaturatedFat = g.Sum(i => i.SaturatedFat),
                                    TransFat = g.Sum(i => i.TransFat),
                                    PolyunsaturatedFat = g.Sum(i => i.PolyunsaturatedFat),
                                    MonounsaturatedFat = g.Sum(i => i.MonounsaturatedFat),
                                    Carbohydrate = g.Sum(i => i.Carbohydrate),
                                    Sugars = g.Sum(i => i.Sugars),
                                    DietaryFibre = g.Sum(i => i.DietaryFibre),
                                    SodiumNa = g.Sum(i => i.SodiumNa),
                                    CalciumCa = g.Sum(i => i.CalciumCa),
                                    PotassiumK = g.Sum(i => i.PotassiumK),
                                    ThiaminB1 = g.Sum(i => i.ThiaminB1),
                                    RiboflavinB2 = g.Sum(i => i.RiboflavinB2),
                                    NiacinB3 = g.Sum(i => i.NiacinB3),
                                    Folate = g.Sum(i => i.Folate),
                                    IronFe = g.Sum(i => i.IronFe),
                                    MagnesiumMg = g.Sum(i => i.MagnesiumMg),
                                    VitaminC = g.Sum(i => i.VitaminC),
                                    Caffeine = g.Sum(i => i.Caffeine),
                                    Cholesterol = g.Sum(i => i.Cholesterol),
                                    Alcohol = g.Sum(i => i.Alcohol)
                                }).
                                Last();

                            // weight of recipe in grams
                            float rAmount = qData.Amount;

                            // scaling multiplier to convert nutrient totals to per 100g for recipe food
                            float X = 100F / rAmount;

                            // string to add to end of recipe foods description. It includes recipe weight in grams 
                            string rsAmount = " {recipe=" + string.Format("{0:N0}", rAmount) + "g} *";
                            //textBox1.Text = rsAmount;

                            context.Foods.Load();

                            // updating the recipe food details (the one with the recordID Key)
                            var editFood = context.Foods.Single(b => b.FoodId == recordID);

                            editFood.FoodDescription = textBoxRecipeFoodDescription.Text + rsAmount;
                            editFood.Energy = qData.Energy * X;
                            editFood.Protein = qData.Protein * X;
                            editFood.FatTotal = qData.FatTotal * X;
                            editFood.SaturatedFat = qData.SaturatedFat * X;
                            editFood.TransFat = qData.TransFat * X;
                            editFood.PolyunsaturatedFat = qData.PolyunsaturatedFat * X;
                            editFood.MonounsaturatedFat = qData.MonounsaturatedFat * X;
                            editFood.Carbohydrate = qData.Carbohydrate * X;
                            editFood.Sugars = qData.Sugars * X;
                            editFood.DietaryFibre = qData.DietaryFibre * X;
                            editFood.SodiumNa = qData.SodiumNa * X;
                            editFood.CalciumCa = qData.CalciumCa * X;
                            editFood.PotassiumK = qData.PotassiumK * X;
                            editFood.ThiaminB1 = qData.ThiaminB1 * X;
                            editFood.RiboflavinB2 = qData.RiboflavinB2 * X;
                            editFood.NiacinB3 = qData.NiacinB3 * X;
                            editFood.Folate = qData.Folate * X;
                            editFood.IronFe = qData.IronFe * X;
                            editFood.MagnesiumMg = qData.MagnesiumMg * X;
                            editFood.VitaminC = qData.VitaminC * X;
                            editFood.Caffeine = qData.Caffeine * X;
                            editFood.Cholesterol = qData.Cholesterol * X;
                            editFood.Alcohol = qData.Alcohol * X;

                            // deletes the "backup" recipe food items (ie. those for which CopyFg==1)
                            var oneData = context.Recipe.Local.ToList().Where(x => (x.CopyFg == 1));
                            context.Recipe.RemoveRange(oneData);

                            context.SaveChanges();
                        }
                        catch // display message that tells you that recipes must contain component foods
                        {
                            // Initializes the variables to pass to the MessageBox.Show method.
                            string message = "A recipe must contain component food items!";
                            string caption = "CANNOT EDIT THIS RECIPE";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;

                            // Displays the MessageBox.
                            MessageBox.Show(message, caption, buttons);

                            // prevents continued processing
                            ignoreBtn = true;
                        }
                        break;
                    case 3: // solid-private
                        mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " #";
                        break;
                    case 4: // liquid-private
                        mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " mL#";
                        break;
                    default:
                        // unattainable
                        break;
                }
            }

            // finish processing unless there where no recipe components foods. 
            if (!ignoreBtn)
            {
                actOnClose = false; // this prevents cancellation actions occuring when this form closes 
                this.Close();
            }
        }

        /***** Events/functions related to cancelling a foods input *****/

        // What needs to be done when the {Cancel} button is pressed
        private void CancelInputAction()
        {
            // this tells the code in the MainForm to CANCEL the addition of a food item to the Foods table 
            mainForm!.actOnFoodAdded = false;

            // delete any provisionally created bits of a recipe if they exist
            CancelAdditionOfRecipe();
        }

        // When {Cancel} button is pressed, also linked to pressing the {Esc} Key
        private void ButtonCancelAddFood_Click(object sender, EventArgs e)
        {
            CancelInputAction();

            actOnClose = false; // this prevents cancellation actions occuring when this form closes 
            this.Close();
        }

        // this makes pressing the {x} button behave exactly the same as pressing the {Cancel} button
        private void FoodInputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // check the reason (UserClosing)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (actOnClose)
                {
                    // then we are in effect pressing the {Cancel} button by pressing the {x} button
                    CancelInputAction();
                }
            }
        }

        // toggles between food input forms/layouts
        private void RadioButtonSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSolid.Checked)
            {
                //ChangeFormSize(0);
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                labelState.Text = "Nutrition information per 100 grams (g)";
                textBoxFoodDescription.Focus();
            }
        }

        private void RadioButtonLiquid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLiquid.Checked)
            {
                //ChangeFormSize(0);
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                labelState.Text = "Nutrition information per 100 millilitres (mL)";
                textBoxFoodDescription.Focus();
            }
        }

        private void RadioButtonRecipie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRecipie.Checked)
            {
                //ChangeFormSize(1);
                tabControlAddType.SelectedTab = tabPageRecipie;
                labelState.Text = "Nutrition information per 100 grams and all ingredients must also be in grams";
                textBoxRecipeFoodDescription.Focus();
            }
        }

        /* Enables the completion of inputting a food or recipie description string by pressing the Enter key
         * No error checking necessary since input is an arbitrary string */
        private void TextBoxFoodDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxRecipeFoodDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        /* Enables the completion of inputting a food or recipe description string by having the text box lose focus,
         * be it by pressing {Shift}{Tab} or just the {Tab} key, or using the Mouse. */
        private void TextBoxFoodDescription_Leave(object sender, EventArgs e)
        {
            mainForm!.addedFoodItem.FoodDescription = textBoxFoodDescription.Text;
        }

        private void TextBoxRecipeFoodDescription_Leave(object sender, EventArgs e)
        {
            if (!recordExists)
            {
                using (var context = new FoodsContext())
                {
                    // this creates the initial main food item record for a recipe. It will be edited (or deleted) later.
                    // It is needed now so we can identify it by its unique FoodId Key.
                    var newFood = new Food()
                    {
                        FoodDescription = textBoxRecipeFoodDescription.Text,
                        Energy = 0F,
                        Protein = 0F,
                        FatTotal = 0F,
                        SaturatedFat = 0F,
                        TransFat = 0F,
                        PolyunsaturatedFat = 0F,
                        MonounsaturatedFat = 0F,
                        Carbohydrate = 0F,
                        Sugars = 0F,
                        DietaryFibre = 0F,
                        SodiumNa = 0F,
                        CalciumCa = 0F,
                        PotassiumK = 0F,
                        ThiaminB1 = 0F,
                        RiboflavinB2 = 0F,
                        NiacinB3 = 0F,
                        Folate = 0F,
                        IronFe = 0F,
                        MagnesiumMg = 0F,
                        VitaminC = 0F,
                        Caffeine = 0F,
                        Cholesterol = 0F,
                        Alcohol = 0F
                    };
                    context.Foods.Add(newFood);
                    context.SaveChanges();
                    recordID = newFood.FoodId;
                    //labelState.Text = string.Format("{0:N0}", recordID);

                    // on first leaving of this textbox create
                    //labelState.Text = textBoxRecipeFoodDescription.Text;

                    // gain access for editing to food item via its known Key
                    var editFood = context.Foods.Single(b => b.FoodId == recordID);
                    context.SaveChanges();
                }

                // so we don't recreate record next time we leave this textBox
                recordExists = true;
            }
            else // if (recordExists)
            {
                using var context = new FoodsContext();
                var editFood = context.Foods.Single(b => b.FoodId == recordID);
                editFood.FoodDescription = textBoxRecipeFoodDescription.Text;
                context.SaveChanges();
            }
        }

        /***** START BLOCK OF EVENT FUNCTIONS *****
         * The following EVENT FUNCTIONS are related to accepting & error managing all number accepting text boxes for Food table fields */

        /* General textBox field comment ***
         * Enables the completion of inputing a field value by pressing the Enter key.
         * which actually sends a Tab key press event that leaves the text box and fires
         * the Leave event that actually accepts/processes the input text.
         * Same comment applies to corresponding functions below   */
        private void TextBoxEnergy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        /* General textBox field comment ***
         * Enables the completion of inputting a field value by having the text box loose focus, be it by pressing 
         * {Shift}{Tab} or just the {Tab} key, or using the Mouse. If the input text does not parse to a positive 
         * float then the text is set to "".
         * Same comment applies to corresponding functions below */
        private void TextBoxEnergy_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxEnergy.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Energy = 0F;
                    textBoxEnergy.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Energy = float.Parse(textBoxEnergy.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Energy = 0F;
                textBoxEnergy.Text = "";
            }
        }

        private void TextBoxProtein_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxProtein_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxProtein.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Protein = 0F;
                    textBoxProtein.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Protein = float.Parse(textBoxProtein.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Protein = 0F;
                textBoxProtein.Text = "";
            }
        }

        private void TextBoxFatTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxFatTotal_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxFatTotal.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.FatTotal = 0F;
                    textBoxFatTotal.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.FatTotal = float.Parse(textBoxFatTotal.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.FatTotal = 0F;
                textBoxFatTotal.Text = "";
            }
        }

        private void TextBoxSaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxSaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSaturatedFat.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.SaturatedFat = 0F;
                    textBoxSaturatedFat.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.SaturatedFat = float.Parse(textBoxSaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.SaturatedFat = 0F;
                textBoxSaturatedFat.Text = "";
            }
        }

        private void TextBoxTransFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxTransFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxTransFat.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.TransFat = 0F;
                    textBoxTransFat.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.TransFat = float.Parse(textBoxTransFat.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.TransFat = 0F;
                textBoxTransFat.Text = "";
            }
        }

        private void TextBoxPolyunsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxPolyunsaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxPolyunsaturatedFat.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.PolyunsaturatedFat = 0F;
                    textBoxPolyunsaturatedFat.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.PolyunsaturatedFat = float.Parse(textBoxPolyunsaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.PolyunsaturatedFat = 0F;
                textBoxPolyunsaturatedFat.Text = "";
            }
        }

        private void TextBoxMonounsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxMonounsaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxMonounsaturatedFat.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.MonounsaturatedFat = 0F;
                    textBoxMonounsaturatedFat.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.MonounsaturatedFat = float.Parse(textBoxMonounsaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.MonounsaturatedFat = 0F;
                textBoxMonounsaturatedFat.Text = "";
            }
        }

        private void TextBoxCarbohydrate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxCarbohydrate_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCarbohydrate.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Carbohydrate = 0F;
                    textBoxCarbohydrate.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Carbohydrate = float.Parse(textBoxCarbohydrate.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Carbohydrate = 0F;
                textBoxCarbohydrate.Text = "";
            }
        }

        private void TextBoxSugars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxSugars_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSugars.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Sugars = 0F;
                    textBoxSugars.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Sugars = float.Parse(textBoxSugars.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Sugars = 0F;
                textBoxSugars.Text = "";
            }
        }

        private void TextBoxDietaryFibre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxDietaryFibre_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxDietaryFibre.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.DietaryFibre = 0F;
                    textBoxDietaryFibre.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.DietaryFibre = float.Parse(textBoxDietaryFibre.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.DietaryFibre = 0F;
                textBoxDietaryFibre.Text = "";
            }
        }

        private void TextBoxSodiumNa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxSodiumNa_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSodiumNa.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.SodiumNa = 0F;
                    textBoxSodiumNa.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.SodiumNa = float.Parse(textBoxSodiumNa.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.SodiumNa = 0F;
                textBoxSodiumNa.Text = "";
            }
        }

        private void TextBoxCalciumCa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxCalciumCa_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCalciumCa.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.CalciumCa = 0F;
                    textBoxCalciumCa.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.CalciumCa = float.Parse(textBoxCalciumCa.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.CalciumCa = 0F;
                textBoxCalciumCa.Text = "";
            }
        }

        private void TextBoxPotassiumK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxPotassiumK_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxPotassiumK.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.PotassiumK = 0F;
                    textBoxPotassiumK.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.PotassiumK = float.Parse(textBoxPotassiumK.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.PotassiumK = 0F;
                textBoxPotassiumK.Text = "";
            }
        }

        private void TextBoxThiaminB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxThiaminB1_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxThiaminB1.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.ThiaminB1 = 0F;
                    textBoxThiaminB1.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.ThiaminB1 = float.Parse(textBoxThiaminB1.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.ThiaminB1 = 0F;
                textBoxThiaminB1.Text = "";
            }
        }

        private void TextBoxRiboflavinB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxRiboflavinB2_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxRiboflavinB2.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.RiboflavinB2 = 0F;
                    textBoxRiboflavinB2.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.RiboflavinB2 = float.Parse(textBoxRiboflavinB2.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.RiboflavinB2 = 0F;
                textBoxRiboflavinB2.Text = "";
            }
        }

        private void TextBoxNiacinB3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxNiacinB3_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxNiacinB3.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.NiacinB3 = 0F;
                    textBoxNiacinB3.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.NiacinB3 = float.Parse(textBoxNiacinB3.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.NiacinB3 = 0F;
                textBoxNiacinB3.Text = "";
            }
        }

        private void TextBoxFolate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxFolate_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxFolate.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Folate = 0F;
                    textBoxFolate.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Folate = float.Parse(textBoxFolate.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Folate = 0F;
                textBoxFolate.Text = "";
            }
        }

        private void TextBoxIronFe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxIronFe_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxIronFe.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.IronFe = 0F;
                    textBoxIronFe.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.IronFe = float.Parse(textBoxIronFe.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.IronFe = 0F;
                textBoxIronFe.Text = "";
            }
        }

        private void TextBoxMagnesiumMg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxMagnesiumMg_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxMagnesiumMg.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.MagnesiumMg = 0F;
                    textBoxMagnesiumMg.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.MagnesiumMg = float.Parse(textBoxMagnesiumMg.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.MagnesiumMg = 0F;
                textBoxMagnesiumMg.Text = "";
            }
        }

        private void TextBoxVitaminC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxVitaminC_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxVitaminC.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.VitaminC = 0F;
                    textBoxVitaminC.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.VitaminC = float.Parse(textBoxVitaminC.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.VitaminC = 0F;
                textBoxVitaminC.Text = "";
            }
        }

        private void TextBoxCaffeine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxCaffeine_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCaffeine.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Caffeine = 0F;
                    textBoxCaffeine.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Caffeine = float.Parse(textBoxCaffeine.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Caffeine = 0F;
                textBoxCaffeine.Text = "";
            }
            //labelState.Text = (textBoxCaffeine.Text);
        }

        private void TextBoxCholesterol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxCholesterol_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCholesterol.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Cholesterol = 0F;
                    textBoxCholesterol.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Cholesterol = float.Parse(textBoxCholesterol.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Cholesterol = 0F;
                textBoxCholesterol.Text = "";
            }
            //labelState.Text = (textBoxCholesterol.Text);
        }

        private void TextBoxAlcohol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxAlcohol_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxAlcohol.Text) < 0.0)
                {
                    mainForm!.addedFoodItem.Alcohol = 0F;
                    textBoxAlcohol.Text = "";
                }
                else
                {
                    mainForm!.addedFoodItem.Alcohol = float.Parse(textBoxAlcohol.Text);
                }
            }
            catch // any exception
            {
                mainForm!.addedFoodItem.Alcohol = 0F;
                textBoxAlcohol.Text = "";
            }
        }

        /* The above EVENT FUNCTIONS are related to accepting & error managing all numeric accepting text boxed for Food table fields
         ***** END BLOCK OF EVENT FUNCTIONS *****/

        // Prepares this form depending on what food type will be processed and whether adding or editing
        // This information is obtained from public variables in the parent form.
        private void FoodInputForm_Shown(object sender, EventArgs e)
        {
            //ChangeFormSize(0);
            if (mainForm!.inputType == 0) // setting up form for ADDING foood item
            {
                // text on this multipurpose button tells us we will be adding food item to tables 
                buttonAddFood.Text = "Add food";

                // reset in case changed by edit state
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                groupBoxFoodTypes.Enabled = true;
                radioButtonSolid.Checked = true;

                // Initialises to default values the fields of a non-recipie food item that is going to be
                // added to the Foods table
                mainForm.addedFoodItem.FoodDescription = "";
                mainForm.addedFoodItem.Energy = 0F;
                mainForm.addedFoodItem.Protein = 0F;
                mainForm.addedFoodItem.FatTotal = 0F;
                mainForm.addedFoodItem.SaturatedFat = 0F;
                mainForm.addedFoodItem.TransFat = 0F;
                mainForm.addedFoodItem.PolyunsaturatedFat = 0F;
                mainForm.addedFoodItem.MonounsaturatedFat = 0F;
                mainForm.addedFoodItem.Carbohydrate = 0F;
                mainForm.addedFoodItem.Sugars = 0F;
                mainForm.addedFoodItem.DietaryFibre = 0F;
                mainForm.addedFoodItem.SodiumNa = 0F;
                mainForm.addedFoodItem.CalciumCa = 0F;
                mainForm.addedFoodItem.PotassiumK = 0F;
                mainForm.addedFoodItem.ThiaminB1 = 0F;
                mainForm.addedFoodItem.RiboflavinB2 = 0F;
                mainForm.addedFoodItem.NiacinB3 = 0F;
                mainForm.addedFoodItem.Folate = 0F;
                mainForm.addedFoodItem.IronFe = 0F;
                mainForm.addedFoodItem.MagnesiumMg = 0F;
                mainForm.addedFoodItem.VitaminC = 0F;
                mainForm.addedFoodItem.Caffeine = 0F;
                mainForm.addedFoodItem.Cholesterol = 0F;
                mainForm.addedFoodItem.Alcohol = 0F;
            }
            else if (mainForm.inputType == 1) // setting up form for EDITING foood item
            {
                // text on this multipurpose button tells us we will be editing existing food item
                buttonAddFood.Text = "Edit food";

                // Set radio button indicating food type being edited
                int foodType = mainForm.foodType;
                if ((foodType == 0) | (foodType == 3))
                {
                    radioButtonSolid.Checked = true;
                    tabControlAddType.SelectedTab = tabPageNonRecipie;
                    labelState.Text = "Nutrition information per 100 grams (g)";
                }
                else if ((foodType == 1) | (foodType == 4))
                {
                    radioButtonLiquid.Checked = true;
                    tabControlAddType.SelectedTab = tabPageNonRecipie;
                    labelState.Text = "Nutrition information per 100 millilitres (mL)";
                }
                else // if (foodType == 2)
                {
                    radioButtonRecipie.Checked = true;
                    tabControlAddType.SelectedTab = tabPageRecipie;
                    labelState.Text = "Nutrition information per 100 grams and all ingredients must also be in grams";
                }

                // disables changes to food type radio buttons
                groupBoxFoodTypes.Enabled = false;

                if (foodType != 2) // dealing with a non-recipe food
                {
                    // populate form with food details
                    textBoxFoodDescription.Text = mainForm.editedFoodItem.FoodDescription;
                    textBoxEnergy.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Energy);
                    textBoxProtein.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Protein);
                    textBoxFatTotal.Text = string.Format("{0:N1}", mainForm.editedFoodItem.FatTotal);
                    textBoxSaturatedFat.Text = string.Format("{0:N1}", mainForm.editedFoodItem.SaturatedFat);
                    textBoxTransFat.Text = string.Format("{0:N1}", mainForm.editedFoodItem.TransFat);
                    textBoxPolyunsaturatedFat.Text = string.Format("{0:N1}", mainForm.editedFoodItem.PolyunsaturatedFat);
                    textBoxMonounsaturatedFat.Text = string.Format("{0:N1}", mainForm.editedFoodItem.MonounsaturatedFat);
                    textBoxCarbohydrate.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Carbohydrate);
                    textBoxSugars.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Sugars);
                    textBoxDietaryFibre.Text = string.Format("{0:N1}", mainForm.editedFoodItem.DietaryFibre);
                    textBoxSodiumNa.Text = string.Format("{0:N0}", mainForm.editedFoodItem.SodiumNa);
                    textBoxCalciumCa.Text = string.Format("{0:N0}", mainForm.editedFoodItem.CalciumCa);
                    textBoxPotassiumK.Text = string.Format("{0:N0}", mainForm.editedFoodItem.PotassiumK);
                    textBoxThiaminB1.Text = string.Format("{0:N1}", mainForm.editedFoodItem.ThiaminB1);
                    textBoxRiboflavinB2.Text = string.Format("{0:N1}", mainForm.editedFoodItem.RiboflavinB2);
                    textBoxNiacinB3.Text = string.Format("{0:N1}", mainForm.editedFoodItem.NiacinB3);
                    textBoxFolate.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Folate);
                    textBoxIronFe.Text = string.Format("{0:N1}", mainForm.editedFoodItem.IronFe);
                    textBoxMagnesiumMg.Text = string.Format("{0:N0}", mainForm.editedFoodItem.MagnesiumMg);
                    textBoxVitaminC.Text = string.Format("{0:N0}", mainForm.editedFoodItem.VitaminC);
                    textBoxCaffeine.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Caffeine);
                    textBoxCholesterol.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Cholesterol);
                    textBoxAlcohol.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Alcohol);

                    // populate addedFoodItem fields with the editedFoodItem fields
                    mainForm.addedFoodItem.FoodDescription = mainForm.editedFoodItem.FoodDescription;
                    mainForm.addedFoodItem.Energy = mainForm.editedFoodItem.Energy;
                    mainForm.addedFoodItem.Protein = mainForm.editedFoodItem.Protein;
                    mainForm.addedFoodItem.FatTotal = mainForm.editedFoodItem.FatTotal;
                    mainForm.addedFoodItem.SaturatedFat = mainForm.editedFoodItem.SaturatedFat;
                    mainForm.addedFoodItem.TransFat = mainForm.editedFoodItem.TransFat;
                    mainForm.addedFoodItem.PolyunsaturatedFat = mainForm.editedFoodItem.PolyunsaturatedFat;
                    mainForm.addedFoodItem.MonounsaturatedFat = mainForm.editedFoodItem.MonounsaturatedFat;
                    mainForm.addedFoodItem.Carbohydrate = mainForm.editedFoodItem.Carbohydrate;
                    mainForm.addedFoodItem.Sugars = mainForm.editedFoodItem.Sugars;
                    mainForm.addedFoodItem.DietaryFibre = mainForm.editedFoodItem.DietaryFibre;
                    mainForm.addedFoodItem.SodiumNa = mainForm.editedFoodItem.SodiumNa;
                    mainForm.addedFoodItem.CalciumCa = mainForm.editedFoodItem.CalciumCa;
                    mainForm.addedFoodItem.PotassiumK = mainForm.editedFoodItem.PotassiumK;
                    mainForm.addedFoodItem.ThiaminB1 = mainForm.editedFoodItem.ThiaminB1;
                    mainForm.addedFoodItem.RiboflavinB2 = mainForm.editedFoodItem.RiboflavinB2;
                    mainForm.addedFoodItem.NiacinB3 = mainForm.editedFoodItem.NiacinB3;
                    mainForm.addedFoodItem.Folate = mainForm.editedFoodItem.Folate;
                    mainForm.addedFoodItem.IronFe = mainForm.editedFoodItem.IronFe;
                    mainForm.addedFoodItem.MagnesiumMg = mainForm.editedFoodItem.MagnesiumMg;
                    mainForm.addedFoodItem.VitaminC = mainForm.editedFoodItem.VitaminC;
                    mainForm.addedFoodItem.Caffeine = mainForm.editedFoodItem.Caffeine;
                    mainForm.addedFoodItem.Cholesterol = mainForm.editedFoodItem.Cholesterol;
                    mainForm.addedFoodItem.Alcohol = mainForm.editedFoodItem.Alcohol;
                }
                else // if (foodType == 2) then deal with a "complicated" recipe food
                {
                    // populate text box with "truncated" food description
                    textBoxRecipeFoodDescription.Text = mainForm.editedFoodItem.FoodDescription;

                    // obtains the Key for this Recipe food item
                    recordID = mainForm.recordID;

                    // duplicate existing recipe components and flag with 1's, this is our backup in case we cancel our edit!
                    using (var context = new FoodsContext())
                    {
                        context.Recipe.Load();

                        // getting component foods for current recipe
                        var RecipeFoods = context.Recipe.Local.ToList().Where(x => (x.FoodId == recordID));

                        // duplicating them
                        foreach (var food in RecipeFoods)
                        {
                            var newFood = new Recipe()
                            {
                                FoodId = recordID,
                                CopyFg = 1, // indicating backup recipe food components
                                Amount = food.Amount,
                                FoodDescription = food.FoodDescription,
                                Energy = food.Energy,
                                Protein = food.Protein,
                                FatTotal = food.FatTotal,
                                SaturatedFat = food.SaturatedFat,
                                TransFat = food.TransFat,
                                PolyunsaturatedFat = food.PolyunsaturatedFat,
                                MonounsaturatedFat = food.MonounsaturatedFat,
                                Carbohydrate = food.Carbohydrate,
                                Sugars = food.Sugars,
                                DietaryFibre = food.DietaryFibre,
                                SodiumNa = food.SodiumNa,
                                CalciumCa = food.CalciumCa,
                                PotassiumK = food.PotassiumK,
                                ThiaminB1 = food.ThiaminB1,
                                RiboflavinB2 = food.RiboflavinB2,
                                NiacinB3 = food.NiacinB3,
                                Folate = food.Folate,
                                IronFe = food.IronFe,
                                MagnesiumMg = food.MagnesiumMg,
                                VitaminC = food.VitaminC,
                                Caffeine = food.Caffeine,
                                Cholesterol = food.Cholesterol,
                                Alcohol = food.Alcohol
                            };
                            context.Recipe.Add(newFood);
                        }
                        context.SaveChanges();
                    }

                    // so that we do not recreate food when we leave description text box
                    recordExists = true;

                    // refreshes the datagrid that displays the recipie's food components
                    RefreshRecipeDataGrid(recordID);
                }
            }
        }

        private void RefreshRecipeDataGrid(int rID)
        {
            using var context = new FoodsContext();
            context.Recipe.Load();

            // start updating dataGrid
            recipeBindingSource.DataSource = context.Foods.Local.ToBindingList();
            var filteredData = context.Recipe.Local.ToBindingList().Where(x => ((x.FoodId == rID) & (x.CopyFg == 0)));
            this.recipeBindingSource.DataSource = filteredData.Any() ? filteredData : filteredData.ToArray();

            // setting focus to first displayed cell in data grid. Ignore (via exception) if nothing is displayed in data grid 
            try
            {
                dataGridViewRecipe.CurrentCell = dataGridViewRecipe.FirstDisplayedCell;
                dataGridViewRecipe.CurrentCell.Selected = true;
                dataGridViewRecipe.Focus();
            }
            catch
            {
                ; // do nothing!
            }
        }

        private void ActWhenRecipeFoodSelected()
        {
            var foodItem = (Food)dataGridViewAddToRecipe.CurrentRow.DataBoundItem;

            if (foodItem != null)
            {
                using var context = new FoodsContext();

                // gain access to selected entry in food table
                var FoodSelected = context.Foods.Single(b => b.FoodId == foodItem.FoodId);
                FoodDescriptionRecipe = FoodSelected.FoodDescription;

                // if selected food is a liquid (ie. measured in mL) then cannot add it to recipe
                if (UnitsString(FoodDescriptionRecipe!) == "mL")
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Only foods measured in grams can be added to a recipe";
                    string caption = "CANNOT ADD THIS FOOD";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons);
                }
                else // selected food is a solid or recipe (ie. measured in g) so can continue processing it
                {
                    // opens dialog used to input the quantity of that food in recipe, position is "locked" in relation to this form
                    InputRecipeComponent frm = new(this)
                    {
                        StartPosition = FormStartPosition.Manual
                    };
                    Point pf = new(12, 55);
                    frm.Location = this.PointToScreen(pf);
                    frm.ShowDialog();

                    // set focus back to food selected
                    dataGridViewAddToRecipe.CurrentCell.Selected = true;

                    if (amountOfFoodInRecipe > 0.0)
                    {
                        //textBox1.Text = string.Format("{0:N2}", amountOfFoodInRecipe);

                        // we can now add the appropriate entry to the Recipe table
                        float X = amountOfFoodInRecipe / 100F;
                        var newFood = new Recipe()
                        {
                            FoodId = recordID,
                            CopyFg = 0,
                            Amount = amountOfFoodInRecipe,
                            FoodDescription = FoodSelected.FoodDescription,
                            Energy = FoodSelected.Energy * X,
                            Protein = FoodSelected.Protein * X,
                            FatTotal = FoodSelected.FatTotal * X,
                            SaturatedFat = FoodSelected.SaturatedFat * X,
                            TransFat = FoodSelected.TransFat * X,
                            PolyunsaturatedFat = FoodSelected.PolyunsaturatedFat * X,
                            MonounsaturatedFat = FoodSelected.MonounsaturatedFat * X,
                            Carbohydrate = FoodSelected.Carbohydrate * X,
                            Sugars = FoodSelected.Sugars * X,
                            DietaryFibre = FoodSelected.DietaryFibre * X,
                            SodiumNa = FoodSelected.SodiumNa * X,
                            CalciumCa = FoodSelected.CalciumCa * X,
                            PotassiumK = FoodSelected.PotassiumK * X,
                            ThiaminB1 = FoodSelected.ThiaminB1 * X,
                            RiboflavinB2 = FoodSelected.RiboflavinB2 * X,
                            NiacinB3 = FoodSelected.NiacinB3 * X,
                            Folate = FoodSelected.Folate * X,
                            IronFe = FoodSelected.IronFe * X,
                            MagnesiumMg = FoodSelected.MagnesiumMg * X,
                            VitaminC = FoodSelected.VitaminC * X,
                            Caffeine = FoodSelected.Caffeine * X,
                            Cholesterol = FoodSelected.Cholesterol * X,
                            Alcohol = FoodSelected.Alcohol * X
                        };
                        context.Recipe.Add(newFood);
                        context.SaveChanges();
                        RefreshRecipeDataGrid(recordID);
                    }
                }
            }
        }

        private void TabPageRecipie_Enter(object sender, EventArgs e)
        {
            RefreshRecipeDataGrid(recordID);
        }

        /* This is way ONE you select a food (for adding to a recipe) from the Food table.
         * - From the Food data grid Double Click selected item with mouse */
        private void DataGridViewAddToRecipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActWhenRecipeFoodSelected();
        }

        /* This is way TWO you select an item (for adding to a recipe) from the Food table.
         * - From the Food data grid Press the Enter key on selected item. */
        private void DataGridViewAddToRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Selecting food item
            {
                ActWhenRecipeFoodSelected();
                e.Handled = true; // prevents Enter key press causing next lower cell getting focus 
            }
        }

        /* Only reacts to the Enter key being pressed in the Food filter text box, by processing the filter request */
        private void TextBoxFilterRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                if (textBoxFilterRecipe.Text == "")
                {
                    labelFilterRecipe.Text = "Unfiltered";
                }
                else
                {
                    labelFilterRecipe.Text = textBoxFilterRecipe.Text;
                }
                textBoxFilterRecipe.Text = "";

                ActOnFoodRecipeFilteringStates(0);
            }
        }

        /* Code that acts on Food filtering states
         * There are 2 states and this makes sure the foods datagrid always correctly displays the data
         * there is an argument which determines the sort order via the Id: 0=Asc, 1=Desc */
        private void ActOnFoodRecipeFilteringStates(int sortingType)
        {
            using var context = new FoodsContext();
            context.Foods.Load();

            // start updating dataGridViewFood
            foodBindingSource.DataSource = context.Foods.Local.ToBindingList();
            if (sortingType == 0)
            {
                foodBindingSource.Sort = "FoodId Asc"; // sort in Ascending order by Id
            }
            else // if (sortingType == 1)
            {
                foodBindingSource.Sort = "FoodId Desc"; // sort in Descending order by Id
            }

            // determine current filter from labelFilter label.
            if (labelFilterRecipe.Text == "Unfiltered")
            {
                ;
            }
            else // if have filer
            {
                var filteredData = context.Foods.Local.ToBindingList().Where(x => x.FoodDescription!.Contains(labelFilterRecipe.Text));
                this.foodBindingSource.DataSource = filteredData.Any() ? filteredData : filteredData.ToArray();
            }

            // setting focus to first displayed cell in data grid. Ignore (via exception) if nothing display in data grid 
            try
            {
                dataGridViewAddToRecipe.CurrentCell = dataGridViewAddToRecipe.FirstDisplayedCell;
                dataGridViewAddToRecipe.CurrentCell.Selected = true;
                dataGridViewAddToRecipe.Focus();
            }
            catch
            {
                ; // do nothing!
            }
        }

        private void DataGridViewRecipe_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // cancel the automatic deletion process (to avoid raising exceptions)
            e.Cancel = true;

            // determine row to be deleted from Recipe table by accessing it in its dataGrid
            var recipeItem = (Recipe)this.dataGridViewRecipe.CurrentRow.DataBoundItem;

            if (recipeItem != null)
            {
                using var context = new FoodsContext();
                // gain direct access to selected entry in Eaten table
                var FoodSelected = context.Recipe.Single(b => b.RecipeId == recipeItem.RecipeId);

                // delete this row from Eaten table
                context.Recipe.Remove(FoodSelected);
                context.SaveChanges();

                // refresh Recipe data grid view while maintaining filter status
                RefreshRecipeDataGrid(recordID);
            }
        }

        private void LabelHelpAddEditFood_MouseHover(object sender, EventArgs e)
        {
            /*
                        if (this.Text == "Form for ADDING food")
                        {
                            UtilitiesRMG.SHelpFind = "#Liquid density dialog";
                        }
                        else // if (this.Text == "Form for EDITING food") 
                        {

                        }
            */
            UtilitiesRMG.SHelpFind = "#" + this.Text;
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditFood.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditFood.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditRecipe_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Adding/Editing a Recipe food";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditRecipe.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditRecipe.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditFilter_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Recipe Ingredient filter TextBox";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditFilter.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditFilter.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditIngredient_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Recipe Ingredient selection DataGrid";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditIngredient.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditIngredient.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditDescription_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Recipe Description TextBox";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditDescription.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditDescription.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditIngredients_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Recipe Ingredients DataGrid";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditIngredients.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditIngredients.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }

        private void LabelHelpAddEditNonRecipe_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Adding/Editing a non Recipe food";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpAddEditNonRecipe.Location).X + iw;
            int iy = this.PointToScreen(labelHelpAddEditNonRecipe.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }
    }
}

