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
            string efd = mainForm!.eatenFoodDescription;
            RDesc rf = TruncFoodDesc(efd);

            // Call textbox's focus method and populate it & the dateTimePicker control with the current values  
            this.textBoxAmount.Focus();
            this.labelDescription.Text = rf.truncDesc; // only show the truncated description (to avoid confusion)

            float afe = mainForm.amountOfFoodEaten; // doing this to avoid compiler warning CS1690
            this.textBoxAmount.Text = afe.ToString();

            this.labelAmount.Text = UnitsString(efd);
        }
    }
}
