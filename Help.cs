using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DietSentry.UtilitiesRMG; // so can use the sHelpFind "global" string variable


namespace DietSentry
{
    public partial class Help : Form
    {
        //        private readonly MainForm? mainForm;

        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            richTextBoxHelp.RightMargin = richTextBoxHelp.Size.Width - 60;

            // load rtf file into richTextBox
            richTextBoxHelp.ReadOnly = false;
            richTextBoxHelp.LoadFile(@"C:\Users\grobl\source\repos\DietSentry\DietSentry.rtf");
            richTextBoxHelp.ReadOnly = true;

            // select the releva help topic in the ComboBox which will 
            // then display upon comboBoxHelp_SelectedIndexChanged firing 
            string sh = UtilitiesRMG.SHelpFind;
            sh = sh[1..]; // get rid of initial "#" character
            int shi = comboBoxHelp.Items.IndexOf(sh); // find position in ComboBox
            comboBoxHelp.SelectedIndex = shi;
        }

        private void RichTextBoxHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) | (e.KeyCode == Keys.Escape) | (e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true; // stops that annoying ding when Enter Key pressed 
                this.Close();
            }
        }

        private void ComboBoxHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = "#" + (string)comboBoxHelp.SelectedItem;

            int rci = this.richTextBoxHelp.Find(st);
            if (rci == -1)
            {
                // this occurs if couldn't find search string
                rci = this.richTextBoxHelp.Find("Help system error");
            }
            richTextBoxHelp.SelectionStart = rci;
            richTextBoxHelp.ScrollToCaret();

            // clear selection view (maintaining position)
            richTextBoxHelp.Focus();
            richTextBoxHelp.DeselectAll();
        }

        private void ComboBoxHelp_Leave(object sender, EventArgs e)
        {
            comboBoxHelp.ForeColor = Color.White;
        }

        private void ComboBoxHelp_Enter(object sender, EventArgs e)
        {
            comboBoxHelp.ForeColor = Color.Black;
        }
    }
}
