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

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.sX = textBoxAmount.Text;
            Close();
        }
    }
}
