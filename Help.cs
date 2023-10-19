﻿using Microsoft.VisualBasic.ApplicationServices;
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
            richTextBoxHelp.LoadFile(@"C:\Users\grobl\source\repos\DietSentry\DietSentry.rtf");

            int rci = this.richTextBoxHelp.Find(mainForm!.sHelpFind);
            richTextBoxHelp.SelectionStart = rci;
            richTextBoxHelp.ScrollToCaret();
            richTextBoxHelp.DeselectAll();


        }
    }
}
