using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plasmoid.Extensions;

namespace Elenchos
{
    public partial class LoginSignupWindow : Form
    {
        public LoginSignupWindow()
        {
            InitializeComponent();
            //this.usernameTextboxLogin.AutoSize = false;
            //this.usernameTextboxLogin.Size = new System.Drawing.Size(268, 30);
            PanelBackgroundLoginSignup.BackColor = Color.FromArgb(125, Color.White);
            PasswordShow.Visible = false;
            PasswordHide.Visible = false;
        }
        
        public class MyTextBox : TextBox //color the textbox
        {
            const int WM_NCPAINT = 0x85;
            const uint RDW_INVALIDATE = 0x1;
            const uint RDW_IUPDATENOW = 0x100;
            const uint RDW_FRAME = 0x400;
            [DllImport("user32.dll")]
            static extern IntPtr GetWindowDC(IntPtr hWnd);
            [DllImport("user32.dll")]
            static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
            [DllImport("user32.dll")]
            static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
            Color borderColor = Color.Blue;
        }

        private void PasswordLabelSignup_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabelSignup_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextboxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextboxLogin_TextChanged(object sender, EventArgs e)
        {
            PasswordShow.Visible = true;
            PasswordTextboxLogin.PasswordChar= '*';
            PasswordTextboxLogin.Text = "";
        }

        private void UsernameLabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordHide_Click(object sender, EventArgs e)
        {
            PasswordHide.Visible = false;
            PasswordShow.Visible = true;
        }

        private void PasswordShow_Click(object sender, EventArgs e)
        {   
            PasswordShow.Visible = false;
            PasswordHide.Visible = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new MainWindow().Show();
        }

        private void ContinueWithoutAccountButton_Click(object sender, EventArgs e)
        {
            new MainWindow().Show();
            Hide();
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            Hide();
        }

        private void BackgroundLoginSignup_Click(object sender, EventArgs e)
        {

        }
    }
}