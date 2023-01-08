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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            //SettingsMinimize.Colors = White;
        }

        private void CloseLoginAndSignup_Click(object sender, EventArgs e)
        {
            var loginSignupClose = Application.OpenForms[0];
            loginSignupClose.Close();
        }

        private void foreverMinimize1_Click(object sender, EventArgs e)
        {

        }
    }
}
