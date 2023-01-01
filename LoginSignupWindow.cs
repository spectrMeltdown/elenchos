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
            public Color BorderColor
            {
                get { return borderColor; }
                set
                {
                    borderColor = value;
                    RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                        RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
                }
            }
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                    BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
                {
                    var hdc = GetWindowDC(this.Handle);
                    using (var g = Graphics.FromHdcInternal(hdc))
                    using (var p = new Pen(BorderColor))
                        g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                    _ = ReleaseDC(this.Handle, hdc);
                }
            }
            protected override void OnSizeChanged(EventArgs e)
            {
                base.OnSizeChanged(e);
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                       RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
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

        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.White), 10, 10, this.Width - 40, this.Height - 60, 10);
            SolidBrush brush = new(
                Color.White
                );
            g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 64, 10);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.White, 0.00f)), 12, 12, this.Width - 44, this.Height - 64, 10);
            g.FillRoundedRectangle(new SolidBrush(Color.White), 12, 12 + ((this.Height - 64) / 2), this.Width - 44, (this.Height - 64) / 2, 10);
            */
/*
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.White), 10, 10, this.Width - 20, this.Height - 40, 10);
            SolidBrush brush = new(Color.White);
            g.FillRoundedRectangle(brush, 12, 12, this.Width, this.Height, 10);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.White, 0.00f)), 12, 12, this.Width, this.Height, 10);
            g.FillRoundedRectangle(new SolidBrush(Color.White), 12, 12 + ((this.Height) -  64/ 2), this.Width, (this.Height) / 2, 10);*/
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
    }
}