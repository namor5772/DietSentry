﻿using Microsoft.EntityFrameworkCore;
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
    public partial class InputForm : Form
    {
        private MainForm? mainForm = null;
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
            this.labelAmount.Text = UnitsString(mainForm.eatenFoodDescription);
            this.labelDescription.Text = mainForm.eatenFoodDescription;
        }


        private void textBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 

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
                mainForm.amountOfFoodEaten = amount / 100.0F;
                Close();
            }
        }

    }
}
