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
        /*
                public Help(Form callingform)
                {
                    mainForm = callingform as MainForm;
                    InitializeComponent();
                }
        */
        private void Help_Load(object sender, EventArgs e)
        {
            // load rtf file into richTextBox
            richTextBoxHelp.LoadFile(@"C:\Users\grobl\source\repos\DietSentry\DietSentry.rtf");

            // using "global" context dependent search string, find its position in rtf help file and make it top row  
            int rci = this.richTextBoxHelp.Find(UtilitiesRMG.SHelpFind);
            richTextBoxHelp.SelectionStart = rci;
            richTextBoxHelp.ScrollToCaret();

            // clear selection view (maintaining position)
            richTextBoxHelp.DeselectAll();
        }
    }
}
