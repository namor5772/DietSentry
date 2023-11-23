using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DietSentry.UtilitiesRMG; // so can use the UnitsString function

namespace DietSentry
{
    public partial class InputRecipeComponent : Form
    {

        private readonly FoodInputForm? foodInputFormX;

        public InputRecipeComponent(Form callingform)
        {
            foodInputFormX = callingform as FoodInputForm;
            InitializeComponent();
        }

        private void InputRecipeComponent_Shown(object sender, EventArgs e)
        {
            // Call textbox's focus method and make sure initial values are setup
            // contents of textBoxAmount are context dependant
            textBoxAmount.Focus();
            if (foodInputFormX!.whoOpen == 0)
            {
                textBoxAmount.Text = "";
            }
            else // if (foodInputFormX!.whoOpen == 1)
            {
                float afr = foodInputFormX!.amountOfFoodInRecipe; // doing this to avoid compiler warning CS1690
                textBoxAmount.Text = afr.ToString("0.0");
                labelAmount.Text = UnitsString(foodInputFormX!.FoodDescriptionRecipe);
            }
            labelDescription.Text = foodInputFormX.FoodDescriptionRecipe;
        }

        private void ActOnEnterKeyPress()
        {
            // if any problems with parsing return 0 
            float amount;
            try
            {
                amount = float.Parse(textBoxAmount.Text);
                if (amount < 0.0)
                {
                    amount = 0F;
                }
            }
            catch // any exception
            {
                amount = 0F;
            }

            if (textBoxAmount.Text == "")
            {
                amount = -1F;
            }

            // collects the input, processes it and assigns it to a variable accessible in the calling form     
            foodInputFormX!.amountOfFoodInRecipe = amount;
            Close();
        }

        private void TextBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                ActOnEnterKeyPress();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // closes form without doing anything
                textBoxAmount.Text = "";
                ActOnEnterKeyPress();
            }
        }

        private void LabelHelpRecipeDialog_MouseHover(object sender, EventArgs e)
        {
            if (foodInputFormX!.whoOpen == 0)
            {
                UtilitiesRMG.SHelpFind = "#Recipe Ingredient amount dialog";

            }
            else // if (foodInputFormX!.whoOpen == 1)
            {
                UtilitiesRMG.SHelpFind = "#Recipe Ingredients amount dialog";
            }

            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpRecipeDialog.Location).X + iw;
            int iy = this.PointToScreen(labelHelpRecipeDialog.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }
    }

}
