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
using static DietSentry.UtilitiesRMG; // so can use the UnitsString & SHelpFind functions


namespace DietSentry
{
    public partial class InputForm : Form
    {
        private readonly MainForm? mainForm = null;
        public InputForm(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
        }

        private void InputForm_Shown(object sender, EventArgs e)
        {
            // Call textbox's focus method and make sure initial value is ""
            this.textBoxAmount.Focus();
            this.textBoxAmount.Text = "";
            this.labelAmount.Text = UnitsString(mainForm!.eatenFoodDescription);
            this.labelDescription.Text = mainForm.eatenFoodDescription;
        }

        private void ActOnEnterKeyPress()
        {
            // if any problems with parsing return 0 and just ignore attempt at adding food to Eaten table
            float amount;
            try
            {
                amount = float.Parse(textBoxAmount.Text);
            }
            catch // any exception
            {
                amount = 0F;
            }

            // collects the input, processes it and assignes it to a variable accessible in the MainForm     
            DateTime dt = dateTimePickerEaten.Value;
            mainForm!.dateTimeEaten = dt;
            mainForm!.amountOfFoodEaten = amount / 100.0F;

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


        private void DateTimePickerEaten_KeyDown(object sender, KeyEventArgs e)
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


        /*
         * Hovering with mouse over any [?] button brings up the help form
         * with the rtf text positioned at the appropriate topic.
         */
        private static void HelpCore(int ix, int iy)
        {
            // sets position and opens help form
            Help frm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(ix, iy)
            };
            frm.Show();
        }

        private void LabelHelpFoodEatenDialog_MouseHover(object sender, EventArgs e)
        {
            UtilitiesRMG.SHelpFind = "#Food eaten dialog";
            int iw = 10; // fudge
            int ih = 18; // fudge
            int ix = this.PointToScreen(labelHelpFoodEatenDialog.Location).X + iw;
            int iy = this.PointToScreen(labelHelpFoodEatenDialog.Location).Y + ih;
            HelpCore(ix, iy);
        }
    }
}
