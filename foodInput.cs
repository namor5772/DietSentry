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
            mainForm.addedFoodItem.FoodDescription = textBoxFoodDescription.Text;
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
                labelState.Text = "Measured in grams (g)";
            }
        }

        private void radioButtonLiquid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLiquid.Checked)
            {
                tabControlAddType.SelectedTab = tabPageNonRecipie;
                labelState.Text = "Measured in millilitres (mL)";
            }
        }

        private void radioButtonRecipie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRecipie.Checked)
            {
                tabControlAddType.SelectedTab = tabPageRecipie;
                labelState.Text = "Measured in grams (g) and all components must also be in grams";
            }
        }
    }
}
