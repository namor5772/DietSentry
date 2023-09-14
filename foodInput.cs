using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietSentry
{
    public partial class foodInputForm : Form
    {

        private MainForm? mainForm = null;
        public foodInputForm(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            // collects the input, processes it and assignes it to a variable accessible in the MainForm     
            /*
            mainForm.addedFoodItem.FoodDescription = textBoxFoodDescription.Text;
            mainForm.addedFoodItem.Energy = float.Parse(textBoxEnergy.Text);
            mainForm.addedFoodItem.Protein = float.Parse(textBoxProtein.Text);
            mainForm.addedFoodItem.FatTotal = float.Parse(textBoxFatTotal.Text);
            mainForm.addedFoodItem.SaturatedFat = float.Parse(textBoxSaturatedFat.Text);
            */


            labelState.Text = mainForm.addedFoodItem.FoodDescription;
            mainForm.SetTextForLabel(mainForm.addedFoodItem.FoodDescription);

            //this.Close();
        }

        private void buttonCancelAddFood_Click(object sender, EventArgs e)
        {
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


        /* Initialises to default values the fields of a non-recipie food item that is going to be
           added to the Foods table, This is enacted when the tab panel is entered (via tabbing into first text box?)
           it simply guarantees that any fields that are not explicitly filled are set as 0F */
        private void tabPageNonRecipie_Enter(object sender, EventArgs e)
        {
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


        private void textBoxFoodDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                // if any problems with parsing return 0 and just ignore attempt at adding food to Eaten table
                try
                {
                    mainForm.addedFoodItem.FoodDescription = textBoxFoodDescription.Text;
                }
                catch // any exception
                {
                    mainForm.addedFoodItem.FoodDescription = "Error FoodDescription";
                }
                SendKeys.Send("{TAB}");
                labelState.Text = mainForm.addedFoodItem.FoodDescription;
            }
        }

        private void textBoxEnergy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

                // if any problems with parsing return 0 and just ignore attempt at adding food to Eaten table
                float x;
                try
                {
                    mainForm.addedFoodItem.Energy = float.Parse(textBoxEnergy.Text);
                    SendKeys.Send("{TAB}");
                }
                catch // any exception
                {
                    mainForm.addedFoodItem.Energy = 0F;
                    textBoxEnergy.Text = "";
                }
                labelState.Text = textBoxEnergy.Text;
            }
        }



        private void textBoxProtein_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxFatTotal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxTransFat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxPolyunsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxMonounsaturatedFat_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxCarbohydrate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSugars_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxDietaryFibre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSodiumNa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxCalciumCa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxPotassiumK_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxThiaminB1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxRiboflavinB2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxNiacinB3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxFolate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxIronFe_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxMagnesiumMg_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxVitaminC_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxCaffeine_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxCholesterol_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxAlcohol_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
