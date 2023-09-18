using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietSentry
{
    public partial class foodInputForm : Form
    {

        private MainForm? mainForm = null;
        public foodInputForm(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
            if (mainForm.inputType == 0)
            {
                this.Text = "Form for ADDING new food item";
            }
            else // if (mainForm.inputType == 1)
            {
                this.Text = "Form for EDITING selected food item";
            }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if (mainForm.inputType == 0)
            {
                // cleaning up form if ADDING foood item

                // By this stage it is assumed that all mainForm.addedFoodItem values are assigned even if just to "" or 0F
                // this tells the code in the MainForm to actually add the recorded Food item to the Foods table
                // and what food type is being added. Sold, Liquid or Recipie
                mainForm.actOnFoodAdded = true;
                if (radioButtonSolid.Checked)
                {
                    mainForm.foodType = 3; // solid-private
                    mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " #";
                }
                else if (radioButtonLiquid.Checked)
                {
                    mainForm.foodType = 4; // liquid-private
                    mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " mL#";
                }
                else // if (radioButtonRecipie.Checked)
                {
                    mainForm.foodType = 2; // recipe
                    mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " *";
                }
            }
            if (mainForm.inputType == 1)
            {
                // cleaning up form if EDITING foood item
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
                        mainForm.addedFoodItem.FoodDescription = (mainForm.addedFoodItem.FoodDescription) + " *";
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
            this.Close();
        }


        // Does nothing (as intended) but close this form
        private void buttonCancelAddFood_Click(object sender, EventArgs e)
        {
            mainForm.actOnFoodAdded = false;

            // this tells the code in the MainForm to CANCEL the addition of a food item to the Foods table 
            this.Close();
        }


        private void radioButtonSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSolid.Checked)
            {
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                labelState.Text = "Nutrition information per 100 grams (g)";
            }
        }


        private void radioButtonLiquid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLiquid.Checked)
            {
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                labelState.Text = "Nutrition information per 100 millilitres (mL)";
            }
        }


        private void radioButtonRecipie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRecipie.Checked)
            {
                tabControlAddType.SelectedTab = tabPageRecipie;
                labelState.Text = "Nutrition information per 100 grams and all ingredients must also be in grams";
            }
        }


        /* Enables the completion of inputing a FoodDescription value by pressing the Enter key
         * No error checking necessary since input is an arbitrary string */
        private void textBoxFoodDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }


        /* Enables the completion of inputting a field value by having the text box loose focus, be it by pressing
         * {Shift}{Tab} or just the {Tab} key, or using the Mouse. */
        private void textBoxFoodDescription_Leave(object sender, EventArgs e)
        {
            mainForm.addedFoodItem.FoodDescription = textBoxFoodDescription.Text;
            labelState.Text = textBoxFoodDescription.Text;
        }


        /***** START BLOCK OF EVEN FUNCTIONS *****
         * The following EVENT FUNCTIONS are related to accepting & error managing all number accepting text boxes for Food table fields */

        /* Enables the completion of inputing a field value by pressing the Enter key.
         * which actually sends a Tab key press event that leaves the text box and fires
         * the Leave event that actually accepts/processes the input text.
         * Same comment applies to corresponding functions below   */
        private void textBoxEnergy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        /* Enables the completion of inputting a field value by having the text box loose focus, be it by pressing 
         * {Shift}{Tab} or just the {Tab} key, or using the Mouse. If the input text does not parse to a positive 
         * float then the text is set to "".
         * Same comment applies to corresponding functions below */
        private void textBoxEnergy_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxEnergy.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Energy = 0F;
                    textBoxEnergy.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Energy = float.Parse(textBoxEnergy.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Energy = 0F;
                textBoxEnergy.Text = "";
            }
            labelState.Text = textBoxEnergy.Text;
        }

        private void textBoxProtein_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxProtein_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxProtein.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Protein = 0F;
                    textBoxProtein.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Protein = float.Parse(textBoxProtein.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Protein = 0F;
                textBoxProtein.Text = "";
            }
            labelState.Text = textBoxProtein.Text;
        }

        private void textBoxFatTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxFatTotal_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxFatTotal.Text) < 0.0)
                {
                    mainForm.addedFoodItem.FatTotal = 0F;
                    textBoxFatTotal.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.FatTotal = float.Parse(textBoxFatTotal.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.FatTotal = 0F;
                textBoxFatTotal.Text = "";
            }
            labelState.Text = (textBoxFatTotal.Text);
        }

        private void textBoxSaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxSaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSaturatedFat.Text) < 0.0)
                {
                    mainForm.addedFoodItem.SaturatedFat = 0F;
                    textBoxSaturatedFat.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.SaturatedFat = float.Parse(textBoxSaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.SaturatedFat = 0F;
                textBoxSaturatedFat.Text = "";
            }
            labelState.Text = (textBoxSaturatedFat.Text);
        }

        private void textBoxTransFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxTransFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxTransFat.Text) < 0.0)
                {
                    mainForm.addedFoodItem.TransFat = 0F;
                    textBoxTransFat.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.TransFat = float.Parse(textBoxTransFat.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.TransFat = 0F;
                textBoxTransFat.Text = "";
            }
            labelState.Text = (textBoxTransFat.Text);
        }

        private void textBoxPolyunsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxPolyunsaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxPolyunsaturatedFat.Text) < 0.0)
                {
                    mainForm.addedFoodItem.PolyunsaturatedFat = 0F;
                    textBoxPolyunsaturatedFat.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.PolyunsaturatedFat = float.Parse(textBoxPolyunsaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.PolyunsaturatedFat = 0F;
                textBoxPolyunsaturatedFat.Text = "";
            }
            labelState.Text = (textBoxPolyunsaturatedFat.Text);
        }

        private void textBoxMonounsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxMonounsaturatedFat_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxMonounsaturatedFat.Text) < 0.0)
                {
                    mainForm.addedFoodItem.MonounsaturatedFat = 0F;
                    textBoxMonounsaturatedFat.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.MonounsaturatedFat = float.Parse(textBoxMonounsaturatedFat.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.MonounsaturatedFat = 0F;
                textBoxMonounsaturatedFat.Text = "";
            }
            labelState.Text = (textBoxMonounsaturatedFat.Text);
        }

        private void textBoxCarbohydrate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxCarbohydrate_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCarbohydrate.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Carbohydrate = 0F;
                    textBoxCarbohydrate.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Carbohydrate = float.Parse(textBoxCarbohydrate.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Carbohydrate = 0F;
                textBoxCarbohydrate.Text = "";
            }
            labelState.Text = (textBoxCarbohydrate.Text);
        }

        private void textBoxSugars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxSugars_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSugars.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Sugars = 0F;
                    textBoxSugars.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Sugars = float.Parse(textBoxSugars.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Sugars = 0F;
                textBoxSugars.Text = "";
            }
            labelState.Text = (textBoxSugars.Text);
        }

        private void textBoxDietaryFibre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxDietaryFibre_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxDietaryFibre.Text) < 0.0)
                {
                    mainForm.addedFoodItem.DietaryFibre = 0F;
                    textBoxDietaryFibre.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.DietaryFibre = float.Parse(textBoxDietaryFibre.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.DietaryFibre = 0F;
                textBoxDietaryFibre.Text = "";
            }
            labelState.Text = (textBoxDietaryFibre.Text);
        }

        private void textBoxSodiumNa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxSodiumNa_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxSodiumNa.Text) < 0.0)
                {
                    mainForm.addedFoodItem.SodiumNa = 0F;
                    textBoxSodiumNa.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.SodiumNa = float.Parse(textBoxSodiumNa.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.SodiumNa = 0F;
                textBoxSodiumNa.Text = "";
            }
            labelState.Text = (textBoxSodiumNa.Text);
        }

        private void textBoxCalciumCa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxCalciumCa_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCalciumCa.Text) < 0.0)
                {
                    mainForm.addedFoodItem.CalciumCa = 0F;
                    textBoxCalciumCa.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.CalciumCa = float.Parse(textBoxCalciumCa.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.CalciumCa = 0F;
                textBoxCalciumCa.Text = "";
            }
            labelState.Text = (textBoxCalciumCa.Text);
        }

        private void textBoxPotassiumK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxPotassiumK_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxPotassiumK.Text) < 0.0)
                {
                    mainForm.addedFoodItem.PotassiumK = 0F;
                    textBoxPotassiumK.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.PotassiumK = float.Parse(textBoxPotassiumK.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.PotassiumK = 0F;
                textBoxPotassiumK.Text = "";
            }
            labelState.Text = (textBoxPotassiumK.Text);
        }

        private void textBoxThiaminB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxThiaminB1_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxThiaminB1.Text) < 0.0)
                {
                    mainForm.addedFoodItem.ThiaminB1 = 0F;
                    textBoxThiaminB1.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.ThiaminB1 = float.Parse(textBoxThiaminB1.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.ThiaminB1 = 0F;
                textBoxThiaminB1.Text = "";
            }
            labelState.Text = (textBoxThiaminB1.Text);
        }

        private void textBoxRiboflavinB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxRiboflavinB2_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxRiboflavinB2.Text) < 0.0)
                {
                    mainForm.addedFoodItem.RiboflavinB2 = 0F;
                    textBoxRiboflavinB2.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.RiboflavinB2 = float.Parse(textBoxRiboflavinB2.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.RiboflavinB2 = 0F;
                textBoxRiboflavinB2.Text = "";
            }
            labelState.Text = (textBoxRiboflavinB2.Text);
        }

        private void textBoxNiacinB3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxNiacinB3_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxNiacinB3.Text) < 0.0)
                {
                    mainForm.addedFoodItem.NiacinB3 = 0F;
                    textBoxNiacinB3.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.NiacinB3 = float.Parse(textBoxNiacinB3.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.NiacinB3 = 0F;
                textBoxNiacinB3.Text = "";
            }
            labelState.Text = (textBoxNiacinB3.Text);

        }

        private void textBoxFolate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxFolate_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxFolate.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Folate = 0F;
                    textBoxFolate.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Folate = float.Parse(textBoxFolate.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Folate = 0F;
                textBoxFolate.Text = "";
            }
            labelState.Text = (textBoxFolate.Text);
        }

        private void textBoxIronFe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxIronFe_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxIronFe.Text) < 0.0)
                {
                    mainForm.addedFoodItem.IronFe = 0F;
                    textBoxIronFe.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.IronFe = float.Parse(textBoxIronFe.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.IronFe = 0F;
                textBoxIronFe.Text = "";
            }
            labelState.Text = (textBoxIronFe.Text);
        }

        private void textBoxMagnesiumMg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxMagnesiumMg_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxMagnesiumMg.Text) < 0.0)
                {
                    mainForm.addedFoodItem.MagnesiumMg = 0F;
                    textBoxMagnesiumMg.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.MagnesiumMg = float.Parse(textBoxMagnesiumMg.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.MagnesiumMg = 0F;
                textBoxMagnesiumMg.Text = "";
            }
            labelState.Text = (textBoxMagnesiumMg.Text);
        }

        private void textBoxVitaminC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxVitaminC_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxVitaminC.Text) < 0.0)
                {
                    mainForm.addedFoodItem.VitaminC = 0F;
                    textBoxVitaminC.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.VitaminC = float.Parse(textBoxVitaminC.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.VitaminC = 0F;
                textBoxVitaminC.Text = "";
            }
            labelState.Text = (textBoxVitaminC.Text);
        }

        private void textBoxCaffeine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxCaffeine_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCaffeine.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Caffeine = 0F;
                    textBoxCaffeine.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Caffeine = float.Parse(textBoxCaffeine.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Caffeine = 0F;
                textBoxCaffeine.Text = "";
            }
            labelState.Text = (textBoxCaffeine.Text);
        }

        private void textBoxCholesterol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxCholesterol_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxCholesterol.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Cholesterol = 0F;
                    textBoxCholesterol.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Cholesterol = float.Parse(textBoxCholesterol.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Cholesterol = 0F;
                textBoxCholesterol.Text = "";
            }
            labelState.Text = (textBoxCholesterol.Text);
        }

        private void textBoxAlcohol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                SendKeys.Send("{TAB}");
            }
        }
        private void textBoxAlcohol_Leave(object sender, EventArgs e)
        {
            // if any problems with parsing return 0 for this field
            try
            {
                if (float.Parse(textBoxAlcohol.Text) < 0.0)
                {
                    mainForm.addedFoodItem.Alcohol = 0F;
                    textBoxAlcohol.Text = "";
                }
                else
                {
                    mainForm.addedFoodItem.Alcohol = float.Parse(textBoxAlcohol.Text);
                }
            }
            catch // any exception
            {
                mainForm.addedFoodItem.Alcohol = 0F;
                textBoxAlcohol.Text = "";
            }
            labelState.Text = (textBoxAlcohol.Text);
        }


        private void foodInputForm_Shown(object sender, EventArgs e)
        {
            if (mainForm.inputType == 0)
            {
                // setting up form for ADDING foood item
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
            else if (mainForm.inputType == 1)
            {
                // setting up form for EDITING foood item
                buttonAddFood.Text = "Edit food";

                // Set the radio button indicating the food type and then disable the ability to change it.
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
                groupBoxFoodTypes.Enabled = false;

                // populate form with food details
                textBoxFoodDescription.Text = mainForm.editedFoodItem.FoodDescription;
                textBoxEnergy.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Energy);
                textBoxProtein.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Protein);
                textBoxFatTotal.Text = string.Format("{0:N1}", mainForm.editedFoodItem.FatTotal);
                textBoxSaturatedFat.Text = string.Format("{0:N2}", mainForm.editedFoodItem.SaturatedFat);
                textBoxTransFat.Text = string.Format("{0:N2}", mainForm.editedFoodItem.TransFat);
                textBoxPolyunsaturatedFat.Text = string.Format("{0:N2}", mainForm.editedFoodItem.PolyunsaturatedFat);
                textBoxMonounsaturatedFat.Text = string.Format("{0:N2}", mainForm.editedFoodItem.MonounsaturatedFat);
                textBoxCarbohydrate.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Carbohydrate);
                textBoxSugars.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Sugars);
                textBoxDietaryFibre.Text = string.Format("{0:N1}", mainForm.editedFoodItem.DietaryFibre);
                textBoxSodiumNa.Text = string.Format("{0:N0}", mainForm.editedFoodItem.SodiumNa);
                textBoxCalciumCa.Text = string.Format("{0:N0}", mainForm.editedFoodItem.CalciumCa);
                textBoxPotassiumK.Text = string.Format("{0:N0}", mainForm.editedFoodItem.PotassiumK);
                textBoxThiaminB1.Text = string.Format("{0:N3}", mainForm.editedFoodItem.ThiaminB1);
                textBoxRiboflavinB2.Text = string.Format("{0:N3}", mainForm.editedFoodItem.RiboflavinB2);
                textBoxNiacinB3.Text = string.Format("{0:N2}", mainForm.editedFoodItem.NiacinB3);
                textBoxFolate.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Folate);
                textBoxIronFe.Text = string.Format("{0:N2}", mainForm.editedFoodItem.IronFe);
                textBoxMagnesiumMg.Text = string.Format("{0:N0}", mainForm.editedFoodItem.MagnesiumMg);
                textBoxVitaminC.Text = string.Format("{0:N0}", mainForm.editedFoodItem.VitaminC);
                textBoxCaffeine.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Caffeine);
                textBoxCholesterol.Text = string.Format("{0:N0}", mainForm.editedFoodItem.Cholesterol);
                textBoxAlcohol.Text = string.Format("{0:N1}", mainForm.editedFoodItem.Alcohol);

                // populate addedFoodItem fields with the editeFoodItem fields
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
        }

    }

    /***** END BLOCK OF EVENT FUNCTIONS *****
     * The above EVENT FUNCTIONS are related to accepting & error managing all numeric accepting text boxed for Food table fields */

}

