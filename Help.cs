using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Help : Form
    {
        private readonly MainForm? mainForm = null;
        public Help(Form callingform)
        {
            mainForm = callingform as MainForm;
            InitializeComponent();
        }


        private void Help_Load(object sender, EventArgs e)
        {
/*
            string rt = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fswiss\fprq2\fcharset0 Calibri Light;}{\f2\fnil\fcharset0 Calibri Light;}}"+
                        @"{\*\generator Riched20 10.0.22621}\viewkind4\uc1 "+
                        @"{\pard\sa200\sl240\slmult1\b\f0\fs40\lang9 Diet Sentry overview\par}"+
                        @"\pard\sa200\sl276\slmult1\kerning2\b0\f1\fs22\lang3081 This application can assist in dieting and healthy nutrition by enabling the user to record the food they eat during the day. In particular the energy (in kJ) and a range of nutrients and ingredients.\kerning0\f2\lang9\par}";

            richTextBoxHelp.Rtf = rt;
*/
// Create an OpenFileDialog to request a file to open.
/*         
            OpenFileDialog openFile1 = new()
            {
                // Initialize the OpenFileDialog to look for RTF files.
                DefaultExt = "*.rtf",
                Filter = "RTF Files|*.rtf"
            };

            // Determine whether the user selected a file from the OpenFileDialog. 
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBoxHelp.LoadFile(@"C:\Users\grobl\source\repos\DietSentry\DietSentry.rtf");
            }
*/
              richTextBoxHelp.LoadFile(@"C:\Users\grobl\source\repos\DietSentry\DietSentry.rtf");
            int rci = this.richTextBoxHelp.Find(mainForm!.sHelpFind);
//            int rcl = this.richTextBoxHelp.GetLineFromCharIndex(rci);
            richTextBoxHelp.SelectionStart = rci;
            richTextBoxHelp.ScrollToCaret();


        }
    }
}
