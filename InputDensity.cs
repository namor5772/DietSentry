using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DietSentry.UtilitiesRMG; // so can use the UnitsString function


namespace DietSentry
{
    public partial class InputDensity : Form
    {
        private readonly MainForm? mainForm = null;

        public InputDensity(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
        }

        private void InputDensity_Shown(object sender, EventArgs e)
        {
            // Call textbox's focus method and make sure initial value is ""
            this.textBoxDensity.Focus();
            this.textBoxDensity.Text = "";
            this.labelDescription.Text = mainForm!.editedFoodDescription;
        }

        private void ActOnEnterKeyPress()
        {
            // if any problems with parsing return 0 
            float amount;
            try
            {
                amount = float.Parse(textBoxDensity.Text);
                if (amount < 0.0)
                {
                    amount = 0F;
                }
            }
            catch // any exception
            {
                amount = 0F;
            }

            if (textBoxDensity.Text == "")
            {
                amount = -1;
            }

            // collects the input, processes it and assignes it to a variable accessible in the MainForm
            // 0 indicates error with input
            mainForm!.densityOfFood = amount;

            Close();
        }

        private void TextBoxDensity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                ActOnEnterKeyPress();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // closes form without doing anything
                textBoxDensity.Text = "";
                ActOnEnterKeyPress();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // closes form without doing anything
                textBoxDensity.Text = "";
                ActOnEnterKeyPress();
            }

        }

 
        private void LabelHelpFoodDensityDialog_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Liquid density dialog";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpFoodDensityDialog.Location).X + iw;
            int iy = this.PointToScreen(labelHelpFoodDensityDialog.Location).Y + ih;
            UtilitiesRMG.HelpCore(ix, iy);
        }
    }
}
