using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Google.Protobuf.Reflection.UninterpretedOption.Types;


namespace Elenchos
{
    public partial class LoginSignupWindow : Form
    {
        Random randomNum = new Random();
        bool signupValidated = false;
        string[] quotearray = { "\"Best for productivity.\"", "\"Award-winning app\"", "\"Love this app!!\"", "\"Uncomparable. Reimagined.\"", "\"I am lost for words.\"" };
        public LoginSignupWindow()
        {
            InitializeComponent();
            Trans(ElenchosLabel, BgLoginSignupWindow);
            Trans(ContinueWithoutAccountButton, BgLoginSignupWindow);
            Trans(QuoteLabel, ElenchosLabel);
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
           
            /*Transition t = new Transition(new TransitionType_Linear(1000));
            t.add(ForgotPasswordLink, "Right", 300);*/
        }

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
            if (PasswordTextboxLogin.PasswordChar == '•')
            {
                PasswordShow.Visible = true;
            }
            else
            {
                PasswordHide.Visible = true;
            }
            CapsLockLabel(CapsLockPanel);
            //PasswordUnderline.ForeColor = Color.LimeGreen;
        }

        private void PasswordTextboxLogin_Leave(object sender, EventArgs e)
        {
            //PasswordUnderline.ForeColor = Color.Black;
            CapsLockPanel.Visible = false;
        }

        private void ContinueWithoutAccountButton_Click(object sender, EventArgs e)
        {
            LoadingScreen loading = new LoadingScreen();
            loading.Dock = DockStyle.Fill;
            loading.Show();
            Thread.Sleep(1000);
            loading.Close();
            new MainWindow().Show();
            this.Hide();
        }

        private void QuoteLabelChange_Tick(object sender, EventArgs e)
        {
            int quote = randomNum.Next(0, 4);
            QuoteLabel.Text = quotearray[quote];
        }

        private void PasswordTextboxLogin_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void PasswordTextboxLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CapsLockLabel(CapsLockPanel);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextboxLogin.Text != string.Empty && (UsernameTextboxLogin.Text != string.Empty))
            {
                MessageBox.Show("This feature is still under development");
                LoginError.Visible = false;
            }
            else
            {
                LoginError.Visible = true;
            }
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
            if (PasswordTextboxSignup.PasswordChar == '•')
            {
                PasswordShowSignup.Visible = true;
            }
            else
            { 
                PasswordHideSignup.Visible = true;
            }
            CapsLockLabel(CapsLockPanelSignup);
        }

        private void PasswordTextboxSignup_Leave(object sender, EventArgs e)
        {
            CapsLockPanelSignup.Visible = false;
        }

        private void PasswordTextboxSignup_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CapsLockLabel(CapsLockPanelSignup);
        }

        private void FirstnameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidName(FirstnameTextbox.Text))
            {
                FirstNameWarningSignup.Visible = true;
                signupValidated = false;
            }
            else
            {
                FirstNameWarningSignup.Visible = false;
                signupValidated = true;
            }
        }

        private void LastnameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidName(LastnameTextbox.Text))
            {
                signupValidated = false;
                LastNameWarningSignup.Visible = true;
            }
            else
            {
                LastNameWarningSignup.Visible = false;
                signupValidated = true;
            }
        }

        private void EmailTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (!(IsValidEmail(EmailTextbox.Text)))
            {
                EmailWarningSignup.Visible = true;
                signupValidated = false;
            } 
            else
            {
                EmailWarningSignup.Visible = false;
                signupValidated = true;
            }
        }

        private void PasswordTextboxSignup_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidPassword(PasswordTextboxSignup.Text))
            {
                PasswordWarningSignup.ForeColor = Color.DarkOrange;
                PasswordWarningSignup.Visible = true;
                signupValidated = false;
            } 
            else
            {
                PasswordWarningSignup.ForeColor = Color.LimeGreen;
                signupValidated = true;
            }
        }

        private void UsernameTextboxSignup_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidUsername(UsernameTextboxSignup.Text))
            {
                UsernameWarningSignup.Visible = true;
                signupValidated = false;
            }
            else
            {
                UsernameWarningSignup.Visible = false;
                signupValidated = true;
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if (signupValidated)
            {
                MessageBox.Show("This feature is still under development");
            }
            else
            {
                MessageBox.Show("Error 101");
            }
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

        //Make controls transparent
        void Trans(Control controlFront, Control controlBack)
        {
            var pos = this.PointToScreen(controlFront.Location);
            pos = controlBack.PointToClient(pos);
            controlFront.Parent = controlBack;
            controlFront.Location = pos;
            controlFront.BackColor = Color.Transparent;
        }

        //If capslock is enabled, display label named control
        void CapsLockLabel(Control label)
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }

        //check emails
        bool IsValidEmail(string email)
        {
            email = email.Trim();

            if (email.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool IsValidName (string name)
        {
            name = name.Trim();
            bool validation = Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$");
            //name = isname.Replace("'", "&#39;");
            return validation;
        }

        bool IsValidPassword (string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            bool validation = 
                hasNumber.IsMatch(password) && 
                hasUpperChar.IsMatch(password) && 
                hasMinimum8Chars.IsMatch(password);

            return validation;
        }

        bool IsValidUsername (string username)
        {
            username = username.Trim();
            bool validation = Regex.IsMatch(username, "^[A-Za-z0-9]+$");
            return validation;
        }

        private void LoginSignupWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            /*System.Windows.Forms.Timer animation = new System.Windows.Forms.Timer();
            animation.Interval = 100;
            animation.Start();
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                animation.Stop();
                this.Hide();
                Application.Exit();
            }*/
        }

        /*
        Sample regex for validation
        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
        if(numberchk.IsMatch(txt_age.Text))

        if (EmailTextbox.Text == string.Empty)
            {
                EmailWarningSignup.Visible = true;
            }
            else 
            {
                Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
                if (!(numberchk.IsMatch(EmailTextbox.Text)))
                {
                    EmailWarningSignup.Visible = true;
                }
            }    
        */

        /*
        ADD LATER
        string selectedTxt = TextBox1.SelectedText;
        TextBox1.SelectedText = "<b>" + selectedTxt + "</b>";
        */
    }
}