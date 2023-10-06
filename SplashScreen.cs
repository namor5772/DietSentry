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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            iTick += 1;
            if (iTick == 50)
            {
                // display slashscreen for 2.5 seconds (ie.50 intervals of 50ms)
                Close();
            }
            else if (iTick <= 20)
            {
                // increase Opacity from 0% to 100% in 20 increments of 50ms 
                Opacity = iTick / 20F;
            }
        }
    }
}
