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
            //PanelBackgroundLoginSignup.BackColor = Color.FromArgb(125, Color.White);
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
        
        //Drop shadow
        private void dropShadow(object sender, PaintEventArgs e)
        {
            Button panel = (Button)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Button p in panel.Controls.OfType<Button>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void PasswordLabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void airForm1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void QuoteLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginSignupWindow_Load(object sender, EventArgs e)
        {
            ContinueWithoutAccountButton.Paint += dropShadow;
        }

        private void ElenchosLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextboxLogin_Click(object sender, EventArgs e)
        {
            PasswordShow.Visible = true;
        }

        private void LoginSignupWindow_Shown(object sender, EventArgs e)
        {
            PasswordShow.Visible = false;
            PasswordHide.Visible = false;
        }

        private void LoginSignupWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}