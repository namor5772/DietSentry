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
    public partial class InputEaten : Form
    {

        private readonly MainForm? mainForm = null;
        public InputEaten(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
        }

        private void InputEaten_Shown(object sender, EventArgs e)
        {
            // Call textbox's focus method
            this.textBoxAmount.Focus();

            // Populate all controls with the current values (from selected eaten food)
            this.labelDescription.Text = TruncFoodDesc(mainForm!.eatenFoodDescription).truncDesc;
            float afe = mainForm.amountOfFoodEaten; // doing this to avoid compiler warning CS1690
            this.textBoxAmount.Text = afe.ToString("0.0");
            this.labelAmount.Text = UnitsString(mainForm.eatenFoodDescription); // g or mL
            this.dateTimePickerEaten.Value = DateTime.Parse(mainForm.sDate + " " + mainForm.sTime);
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
            mainForm!.amountOfFoodEaten = amount;

            Close();
        }


        private void TextBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
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
        }
    }
}
