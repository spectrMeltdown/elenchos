using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elenchos
{
    public partial class LoginSignupWindow : Form
    {

        public static class QuotesChange
        {
            public static string[] quotearray = { "\"Best for productivity.\"", "\"Award-winning app\"", "\"Love this app!!\"", "\"Uncomparable. Reimagined.\"", "\"I am lost for words.\"" };
        }

        public LoginSignupWindow()
        {
            InitializeComponent();


            Trans(ElenchosLabel, BgLoginSignupWindow);
            Trans(ContinueWithoutAccountButton, BgLoginSignupWindow);
            Trans(QuoteLabel, ElenchosLabel);
            //dodat(UsernameUnderline, WhiteBGUsernameLogin);
            //dodat(PasswordUnderline, WhiteBGPasswordLogin);

            //Make controls transparent
            void Trans(Control controlFront, Control controlBack)
            {
                var pos = this.PointToScreen(controlFront.Location);
                pos = controlBack.PointToClient(pos);
                controlFront.Parent = controlBack;
                controlFront.Location = pos;
                controlFront.BackColor = Color.Transparent;
            }
        }

        //-----------------------------------------------------------------------------------
        //------------------------------------LOGIN PAGE-------------------------------------
        //-----------------------------------------------------------------------------------

        private void LoginSignupWindow_Load(object sender, EventArgs e)
        {
            //ContinueWithoutAccountButton.Paint += dropShadow;
        }

        private void LoginSignupWindow_Shown(object sender, EventArgs e)
        {
            PasswordShow.Visible = false;
            PasswordHide.Visible = false;
            /*CapsLockPanel.Visible = false;
            FirstNameWarningSignup.Visible = false;
            LastNameWarningSignup.Visible = false;
            EmailWarningSignup.Visible = false;
            UsernameWarningSignup.Visible = false;
            PasswordWarningSignup.Visible = false;*/
            /*Transition t = new Transition(new TransitionType_Linear(1000));
            t.add(ForgotPasswordLink, "Right", 300);*/
        }

        //Drag window
        private void LoginSignupWindowControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UsernameTextboxLogin_Click(object sender, EventArgs e)
        {
            //UsernameUnderline.ForeColor = Color.LimeGreen;
        }

        private void UsernameTextboxLogin_Leave(object sender, EventArgs e)
        {
            //UsernameUnderline.ForeColor = Color.Black;
        }

        private void PasswordHide_Click(object sender, EventArgs e)
        {
            PasswordHide.Visible = false;
            PasswordShow.Visible = true;
            PasswordTextboxLogin.PasswordChar = '•';

        }

        private void PasswordShow_Click(object sender, EventArgs e)
        {
            PasswordShow.Visible = false;
            PasswordHide.Visible = true;
            PasswordTextboxLogin.PasswordChar = '\0';
        }

        private void PasswordTextboxLogin_Click(object sender, EventArgs e)
        {
            PasswordShow.Visible = true;
            //PasswordUnderline.ForeColor = Color.LimeGreen;
        }

        private void PasswordTextboxLogin_Leave(object sender, EventArgs e)
        {
            //PasswordUnderline.ForeColor = Color.Black;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new MainWindow().Show();
        }

        private void ContinueWithoutAccountButton_Click(object sender, EventArgs e)
        {
            Form recover = new RecoverPassword();
            recover.ShowDialog();
            recover.Dispose();
        }

        //changes quotes every X seconds
        private void QuoteLabelChange_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int quote = ran.Next(0, 4);
            QuoteLabel.Text = QuotesChange.quotearray[quote];
        }

        //------------------------------------------------------------------------------------
        //------------------------------------SIGNUP PAGE-------------------------------------
        //------------------------------------------------------------------------------------

        private void PasswordHideSignup_Click(object sender, EventArgs e)
        {
            PasswordHideSignup.Visible = false;
            PasswordShowSignup.Visible = true;
            PasswordTextboxSignup.PasswordChar = '•';
        }

        private void PasswordShowSignup_Click(object sender, EventArgs e)
        {
            PasswordShowSignup.Visible = false;
            PasswordHideSignup.Visible = true;
            PasswordTextboxSignup.PasswordChar = '\0';
        }

        private void EmailTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (EmailTextbox.Text == string.Empty)
            {
                Error.SetError(EmailSignupErrorBox, "Please Enter Name");
                /*errorProvider1.SetError(txt_name, "");
                errorProvider1.SetError(txt_name, "");*/
            }
        }

        private void PasswordTextboxLogin_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void FirstnameTextbox_Click(object sender, EventArgs e)
        {

        }

        private void LastnameTextbox_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextboxSignup_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextboxSignup_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------
        //---------------------------------CUSTOM CONTROLS------------------------------------
        //------------------------------------------------------------------------------------

        //Colorized Textbox
        public class ColorTextbox : TextBox
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

        //------------------------------------------------------------------------------------
        //------------------------------------OTHER-------------------------------------------
        //------------------------------------------------------------------------------------

                //Event
                class Counter
                {
                    public event EventHandler ThresholdReached;
                    public EventArgs e = null;
                    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);
                    protected virtual void OnThresholdReached(EventArgs e)
                    {
                        ThresholdReached?.Invoke(this, e);
                    }

                    // provide remaining implementation for the class
                }

                //Delegate



                //Event data
                public class ThresholdReachedEventArgs : EventArgs
                {
                    public int Threshold { get; set; }
                    public DateTime TimeReached { get; set; }
                }

                //Event handler
                static void c_ThresholdReached(object sender, EventArgs e)
                {
                    Console.WriteLine("The threshold was reached.");
                }

        //Make image transparent via bitmap
        private static Bitmap MakeTransparent(Bitmap bitmap, Color color, int tolerance)
        {
            Bitmap transparentImage = new Bitmap(bitmap);
            for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
            {
                for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
                {
                    var currentColor = transparentImage.GetPixel(i, j);
                    if (Math.Abs(color.R - currentColor.R) < tolerance &&
                      Math.Abs(color.G - currentColor.G) < tolerance &&
                      Math.Abs(color.B - currentColor.B) < tolerance)
                        transparentImage.SetPixel(i, j, color);
                }
            }
            transparentImage.MakeTransparent(color);
            return transparentImage;
        }

        //Drop shadow
        private void DropShadow(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel panel = (System.Windows.Forms.Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (System.Windows.Forms.Panel p in panel.Controls.OfType<System.Windows.Forms.Panel>())
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

        

        private void PasswordTextboxLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                CapsLockPanel.Visible = true;
                CapsLockWarningLabel.Visible = true;
                CapsLockWarningIcon.Visible = true;
            }
            else
            {
                CapsLockPanel.Visible = false;
                CapsLockWarningLabel.Visible = true;
                CapsLockWarningIcon.Visible = true;
            }
        }
        /*
           CREATE CUSTOM TEXTBOX FOR PASSWORD THAT INHERITS THIS TO SUPPRESS THE TOOLTIP MESSAGE
           private const int EM_SHOWBALLOONTIP = 0x1503;
           public bool DisableBalloonTips { get; set; }

           protected override void WndProc(ref Message m)
           {
               if (m.Msg == EM_SHOWBALLOONTIP && DisableBalloonTips)
               {
                   m.Result = (IntPtr)0;
                   return;
               }
               base.WndProc(ref m);
           }
      }
        */


        /*
        Sample regex for validation
        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
        if(numberchk.IsMatch(txt_age.Text))
        */

        /*
        ADD LATER
        string selectedTxt = TextBox1.SelectedText;
        TextBox1.SelectedText = "<b>" + selectedTxt + "</b>";
        */

    }
}