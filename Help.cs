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
        public Help(MainForm mainForm)
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
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
                richTextBoxHelp.LoadFile(openFile1.FileName);
 //               richTextBoxHelp.Cursor = Cursors.No;
            }
        }
    }
}
