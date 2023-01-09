using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elenchos
{
    public partial class LoadingScreen : Form
    {
       
        public LoadingScreen()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            if (counter != 3)
            {
                LoadingText.Text += " .";
                counter++;
            }
            else
            {
                LoadingText.Text = "Logging in";
                counter = 0;
            }
        }
    }
}
