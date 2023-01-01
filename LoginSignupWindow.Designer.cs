using Plasmoid.Extensions;

namespace Elenchos
{
    partial class LoginSignupWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSignupWindow));
            this.LoginSignupTabControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.PasswordIconLogin = new System.Windows.Forms.PictureBox();
            this.UsernameIconLogin = new System.Windows.Forms.PictureBox();
            this.UsernameLabelLogin = new System.Windows.Forms.Label();
            this.PasswordLabelLogin = new System.Windows.Forms.Label();
            this.ForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordBackgroundLogin = new System.Windows.Forms.Panel();
            this.PasswordTextboxLogin = new System.Windows.Forms.TextBox();
            this.PasswordShow = new System.Windows.Forms.PictureBox();
            this.PasswordHide = new System.Windows.Forms.PictureBox();
            this.UsernameBackgroundLogin = new System.Windows.Forms.Panel();
            this.UsernameTextboxLogin = new System.Windows.Forms.TextBox();
            this.SignupPage = new System.Windows.Forms.TabPage();
            this.TermsAndConditionsLink = new System.Windows.Forms.LinkLabel();
            this.TermsAndConditionsCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordTextboxSignup = new System.Windows.Forms.TextBox();
            this.UsernameTextboxSignup = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.LastnameTextbox = new System.Windows.Forms.TextBox();
            this.EmailLabelSignup = new System.Windows.Forms.Label();
            this.FirstnameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabelSignup = new System.Windows.Forms.Label();
            this.UsernameLabelSignup = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.ContinueWithoutAccountButton = new System.Windows.Forms.Button();
            this.ElenchosLabel = new System.Windows.Forms.Label();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.PanelBackgroundLoginSignup = new System.Windows.Forms.Panel();
            this.BackgroundLoginSignup = new System.Windows.Forms.PictureBox();
            this.LoginSignupTabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconLogin)).BeginInit();
            this.PasswordBackgroundLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordHide)).BeginInit();
            this.UsernameBackgroundLogin.SuspendLayout();
            this.SignupPage.SuspendLayout();
            this.PanelBackgroundLoginSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundLoginSignup)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginSignupTabControl
            // 
            this.LoginSignupTabControl.Controls.Add(this.LoginPage);
            this.LoginSignupTabControl.Controls.Add(this.SignupPage);
            this.LoginSignupTabControl.Location = new System.Drawing.Point(259, 133);
            this.LoginSignupTabControl.Name = "LoginSignupTabControl";
            this.LoginSignupTabControl.Padding = new System.Drawing.Point(90, 5);
            this.LoginSignupTabControl.SelectedIndex = 0;
            this.LoginSignupTabControl.Size = new System.Drawing.Size(439, 337);
            this.LoginSignupTabControl.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.Transparent;
            this.LoginPage.Controls.Add(this.PasswordIconLogin);
            this.LoginPage.Controls.Add(this.UsernameIconLogin);
            this.LoginPage.Controls.Add(this.UsernameLabelLogin);
            this.LoginPage.Controls.Add(this.PasswordLabelLogin);
            this.LoginPage.Controls.Add(this.ForgotPasswordLink);
            this.LoginPage.Controls.Add(this.LoginButton);
            this.LoginPage.Controls.Add(this.PasswordBackgroundLogin);
            this.LoginPage.Controls.Add(this.UsernameBackgroundLogin);
            this.LoginPage.Location = new System.Drawing.Point(4, 28);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(431, 305);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            // 
            // PasswordIconLogin
            // 
            this.PasswordIconLogin.Image = ((System.Drawing.Image)(resources.GetObject("PasswordIconLogin.Image")));
            this.PasswordIconLogin.Location = new System.Drawing.Point(77, 128);
            this.PasswordIconLogin.Name = "PasswordIconLogin";
            this.PasswordIconLogin.Size = new System.Drawing.Size(18, 18);
            this.PasswordIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordIconLogin.TabIndex = 6;
            this.PasswordIconLogin.TabStop = false;
            // 
            // UsernameIconLogin
            // 
            this.UsernameIconLogin.Image = ((System.Drawing.Image)(resources.GetObject("UsernameIconLogin.Image")));
            this.UsernameIconLogin.Location = new System.Drawing.Point(77, 64);
            this.UsernameIconLogin.Name = "UsernameIconLogin";
            this.UsernameIconLogin.Size = new System.Drawing.Size(18, 16);
            this.UsernameIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernameIconLogin.TabIndex = 6;
            this.UsernameIconLogin.TabStop = false;
            // 
            // UsernameLabelLogin
            // 
            this.UsernameLabelLogin.AutoSize = true;
            this.UsernameLabelLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabelLogin.Location = new System.Drawing.Point(95, 64);
            this.UsernameLabelLogin.Name = "UsernameLabelLogin";
            this.UsernameLabelLogin.Size = new System.Drawing.Size(78, 19);
            this.UsernameLabelLogin.TabIndex = 4;
            this.UsernameLabelLogin.Text = "Username: ";
            // 
            // PasswordLabelLogin
            // 
            this.PasswordLabelLogin.AutoSize = true;
            this.PasswordLabelLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabelLogin.Location = new System.Drawing.Point(96, 127);
            this.PasswordLabelLogin.Name = "PasswordLabelLogin";
            this.PasswordLabelLogin.Size = new System.Drawing.Size(70, 19);
            this.PasswordLabelLogin.TabIndex = 4;
            this.PasswordLabelLogin.Text = "Password:";
            // 
            // ForgotPasswordLink
            // 
            this.ForgotPasswordLink.AutoSize = true;
            this.ForgotPasswordLink.Location = new System.Drawing.Point(74, 195);
            this.ForgotPasswordLink.Name = "ForgotPasswordLink";
            this.ForgotPasswordLink.Size = new System.Drawing.Size(100, 15);
            this.ForgotPasswordLink.TabIndex = 3;
            this.ForgotPasswordLink.TabStop = true;
            this.ForgotPasswordLink.Text = "Forgot Password?";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(20, 239);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(395, 51);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Let\'s go !!";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordBackgroundLogin
            // 
            this.PasswordBackgroundLogin.BackColor = System.Drawing.Color.White;
            this.PasswordBackgroundLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBackgroundLogin.Controls.Add(this.PasswordTextboxLogin);
            this.PasswordBackgroundLogin.Controls.Add(this.PasswordShow);
            this.PasswordBackgroundLogin.Controls.Add(this.PasswordHide);
            this.PasswordBackgroundLogin.Location = new System.Drawing.Point(74, 152);
            this.PasswordBackgroundLogin.Name = "PasswordBackgroundLogin";
            this.PasswordBackgroundLogin.Size = new System.Drawing.Size(283, 32);
            this.PasswordBackgroundLogin.TabIndex = 5;
            // 
            // PasswordTextboxLogin
            // 
            this.PasswordTextboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextboxLogin.Location = new System.Drawing.Point(6, 7);
            this.PasswordTextboxLogin.Name = "PasswordTextboxLogin";
            this.PasswordTextboxLogin.Size = new System.Drawing.Size(244, 16);
            this.PasswordTextboxLogin.TabIndex = 2;
            // 
            // PasswordShow
            // 
            this.PasswordShow.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("PasswordShow.Image")));
            this.PasswordShow.Location = new System.Drawing.Point(256, 5);
            this.PasswordShow.Name = "PasswordShow";
            this.PasswordShow.Size = new System.Drawing.Size(20, 20);
            this.PasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordShow.TabIndex = 8;
            this.PasswordShow.TabStop = false;
            this.PasswordShow.Click += new System.EventHandler(this.PasswordShow_Click);
            // 
            // PasswordHide
            // 
            this.PasswordHide.Image = ((System.Drawing.Image)(resources.GetObject("PasswordHide.Image")));
            this.PasswordHide.Location = new System.Drawing.Point(256, 5);
            this.PasswordHide.Name = "PasswordHide";
            this.PasswordHide.Size = new System.Drawing.Size(20, 20);
            this.PasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordHide.TabIndex = 6;
            this.PasswordHide.TabStop = false;
            this.PasswordHide.Click += new System.EventHandler(this.PasswordHide_Click);
            // 
            // UsernameBackgroundLogin
            // 
            this.UsernameBackgroundLogin.BackColor = System.Drawing.Color.White;
            this.UsernameBackgroundLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameBackgroundLogin.Controls.Add(this.UsernameTextboxLogin);
            this.UsernameBackgroundLogin.Location = new System.Drawing.Point(74, 88);
            this.UsernameBackgroundLogin.Name = "UsernameBackgroundLogin";
            this.UsernameBackgroundLogin.Size = new System.Drawing.Size(283, 32);
            this.UsernameBackgroundLogin.TabIndex = 5;
            // 
            // UsernameTextboxLogin
            // 
            this.UsernameTextboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextboxLogin.Location = new System.Drawing.Point(6, 7);
            this.UsernameTextboxLogin.Name = "UsernameTextboxLogin";
            this.UsernameTextboxLogin.Size = new System.Drawing.Size(268, 16);
            this.UsernameTextboxLogin.TabIndex = 1;
            // 
            // SignupPage
            // 
            this.SignupPage.Controls.Add(this.TermsAndConditionsLink);
            this.SignupPage.Controls.Add(this.TermsAndConditionsCheckbox);
            this.SignupPage.Controls.Add(this.PasswordTextboxSignup);
            this.SignupPage.Controls.Add(this.UsernameTextboxSignup);
            this.SignupPage.Controls.Add(this.EmailTextbox);
            this.SignupPage.Controls.Add(this.LastnameTextbox);
            this.SignupPage.Controls.Add(this.EmailLabelSignup);
            this.SignupPage.Controls.Add(this.FirstnameTextbox);
            this.SignupPage.Controls.Add(this.PasswordLabelSignup);
            this.SignupPage.Controls.Add(this.UsernameLabelSignup);
            this.SignupPage.Controls.Add(this.LastnameLabel);
            this.SignupPage.Controls.Add(this.FirstnameLabel);
            this.SignupPage.Controls.Add(this.SignupButton);
            this.SignupPage.Location = new System.Drawing.Point(4, 28);
            this.SignupPage.Name = "SignupPage";
            this.SignupPage.Padding = new System.Windows.Forms.Padding(3);
            this.SignupPage.Size = new System.Drawing.Size(431, 305);
            this.SignupPage.TabIndex = 1;
            this.SignupPage.Text = "Sign up";
            this.SignupPage.UseVisualStyleBackColor = true;
            // 
            // TermsAndConditionsLink
            // 
            this.TermsAndConditionsLink.AutoSize = true;
            this.TermsAndConditionsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.TermsAndConditionsLink.Location = new System.Drawing.Point(123, 226);
            this.TermsAndConditionsLink.Name = "TermsAndConditionsLink";
            this.TermsAndConditionsLink.Size = new System.Drawing.Size(119, 15);
            this.TermsAndConditionsLink.TabIndex = 4;
            this.TermsAndConditionsLink.TabStop = true;
            this.TermsAndConditionsLink.Text = "terms and conditions";
            // 
            // TermsAndConditionsCheckbox
            // 
            this.TermsAndConditionsCheckbox.AutoSize = true;
            this.TermsAndConditionsCheckbox.Location = new System.Drawing.Point(34, 225);
            this.TermsAndConditionsCheckbox.Name = "TermsAndConditionsCheckbox";
            this.TermsAndConditionsCheckbox.Size = new System.Drawing.Size(98, 19);
            this.TermsAndConditionsCheckbox.TabIndex = 3;
            this.TermsAndConditionsCheckbox.Text = "I agree to the ";
            this.TermsAndConditionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // PasswordTextboxSignup
            // 
            this.PasswordTextboxSignup.Location = new System.Drawing.Point(33, 185);
            this.PasswordTextboxSignup.Name = "PasswordTextboxSignup";
            this.PasswordTextboxSignup.Size = new System.Drawing.Size(352, 23);
            this.PasswordTextboxSignup.TabIndex = 2;
            // 
            // UsernameTextboxSignup
            // 
            this.UsernameTextboxSignup.Location = new System.Drawing.Point(33, 139);
            this.UsernameTextboxSignup.Name = "UsernameTextboxSignup";
            this.UsernameTextboxSignup.Size = new System.Drawing.Size(352, 23);
            this.UsernameTextboxSignup.TabIndex = 2;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(33, 94);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(352, 23);
            this.EmailTextbox.TabIndex = 2;
            this.EmailTextbox.TextChanged += new System.EventHandler(this.EmailTextbox_TextChanged);
            // 
            // LastnameTextbox
            // 
            this.LastnameTextbox.Location = new System.Drawing.Point(221, 41);
            this.LastnameTextbox.Name = "LastnameTextbox";
            this.LastnameTextbox.Size = new System.Drawing.Size(164, 23);
            this.LastnameTextbox.TabIndex = 2;
            // 
            // EmailLabelSignup
            // 
            this.EmailLabelSignup.AutoSize = true;
            this.EmailLabelSignup.Location = new System.Drawing.Point(33, 76);
            this.EmailLabelSignup.Name = "EmailLabelSignup";
            this.EmailLabelSignup.Size = new System.Drawing.Size(42, 15);
            this.EmailLabelSignup.TabIndex = 1;
            this.EmailLabelSignup.Text = "Email :";
            // 
            // FirstnameTextbox
            // 
            this.FirstnameTextbox.Location = new System.Drawing.Point(33, 41);
            this.FirstnameTextbox.Name = "FirstnameTextbox";
            this.FirstnameTextbox.Size = new System.Drawing.Size(159, 23);
            this.FirstnameTextbox.TabIndex = 2;
            // 
            // PasswordLabelSignup
            // 
            this.PasswordLabelSignup.AutoSize = true;
            this.PasswordLabelSignup.Location = new System.Drawing.Point(33, 167);
            this.PasswordLabelSignup.Name = "PasswordLabelSignup";
            this.PasswordLabelSignup.Size = new System.Drawing.Size(63, 15);
            this.PasswordLabelSignup.TabIndex = 1;
            this.PasswordLabelSignup.Text = "Password :";
            // 
            // UsernameLabelSignup
            // 
            this.UsernameLabelSignup.AutoSize = true;
            this.UsernameLabelSignup.Location = new System.Drawing.Point(32, 122);
            this.UsernameLabelSignup.Name = "UsernameLabelSignup";
            this.UsernameLabelSignup.Size = new System.Drawing.Size(66, 15);
            this.UsernameLabelSignup.TabIndex = 1;
            this.UsernameLabelSignup.Text = "Username :";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(221, 23);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(69, 15);
            this.LastnameLabel.TabIndex = 1;
            this.LastnameLabel.Text = "Last Name :";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(33, 23);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(70, 15);
            this.FirstnameLabel.TabIndex = 1;
            this.FirstnameLabel.Text = "First Name :";
            // 
            // SignupButton
            // 
            this.SignupButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignupButton.Location = new System.Drawing.Point(14, 251);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(403, 45);
            this.SignupButton.TabIndex = 0;
            this.SignupButton.Text = "Sign me up!";
            this.SignupButton.UseVisualStyleBackColor = true;
            // 
            // ContinueWithoutAccountButton
            // 
            this.ContinueWithoutAccountButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueWithoutAccountButton.Location = new System.Drawing.Point(26, 455);
            this.ContinueWithoutAccountButton.Name = "ContinueWithoutAccountButton";
            this.ContinueWithoutAccountButton.Size = new System.Drawing.Size(502, 51);
            this.ContinueWithoutAccountButton.TabIndex = 1;
            this.ContinueWithoutAccountButton.Text = "Continue without Account";
            this.ContinueWithoutAccountButton.UseVisualStyleBackColor = true;
            // 
            // ElenchosLabel
            // 
            this.ElenchosLabel.AutoSize = true;
            this.ElenchosLabel.BackColor = System.Drawing.Color.Transparent;
            this.ElenchosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ElenchosLabel.Location = new System.Drawing.Point(202, 33);
            this.ElenchosLabel.Name = "ElenchosLabel";
            this.ElenchosLabel.Size = new System.Drawing.Size(134, 31);
            this.ElenchosLabel.TabIndex = 2;
            this.ElenchosLabel.Text = "Elenchos";
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.QuoteLabel.Location = new System.Drawing.Point(390, 93);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(170, 21);
            this.QuoteLabel.TabIndex = 2;
            this.QuoteLabel.Text = "\"Time waits on no one\"";
            this.QuoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelBackgroundLoginSignup
            // 
            this.PanelBackgroundLoginSignup.Controls.Add(this.ElenchosLabel);
            this.PanelBackgroundLoginSignup.Controls.Add(this.ContinueWithoutAccountButton);
            this.PanelBackgroundLoginSignup.Location = new System.Drawing.Point(207, 29);
            this.PanelBackgroundLoginSignup.Name = "PanelBackgroundLoginSignup";
            this.PanelBackgroundLoginSignup.Size = new System.Drawing.Size(549, 523);
            this.PanelBackgroundLoginSignup.TabIndex = 7;
            this.PanelBackgroundLoginSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            // 
            // BackgroundLoginSignup
            // 
            this.BackgroundLoginSignup.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundLoginSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundLoginSignup.Image = ((System.Drawing.Image)(resources.GetObject("BackgroundLoginSignup.Image")));
            this.BackgroundLoginSignup.Location = new System.Drawing.Point(0, 0);
            this.BackgroundLoginSignup.Name = "BackgroundLoginSignup";
            this.BackgroundLoginSignup.Size = new System.Drawing.Size(960, 576);
            this.BackgroundLoginSignup.TabIndex = 8;
            this.BackgroundLoginSignup.TabStop = false;
            // 
            // LoginSignupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 576);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.LoginSignupTabControl);
            this.Controls.Add(this.PanelBackgroundLoginSignup);
            this.Controls.Add(this.BackgroundLoginSignup);
            this.Name = "LoginSignupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.LoginSignupTabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconLogin)).EndInit();
            this.PasswordBackgroundLogin.ResumeLayout(false);
            this.PasswordBackgroundLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordHide)).EndInit();
            this.UsernameBackgroundLogin.ResumeLayout(false);
            this.UsernameBackgroundLogin.PerformLayout();
            this.SignupPage.ResumeLayout(false);
            this.SignupPage.PerformLayout();
            this.PanelBackgroundLoginSignup.ResumeLayout(false);
            this.PanelBackgroundLoginSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundLoginSignup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl LoginSignupTabControl;
        private TabPage LoginPage;
        private TabPage SignupPage;
        private Button ContinueWithoutAccountButton;
        private Label ElenchosLabel;
        private Label QuoteLabel;
        private Label UsernameLabelLogin;
        private Label PasswordLabelLogin;
        private LinkLabel ForgotPasswordLink;
        private TextBox PasswordTextboxLogin;
        private TextBox UsernameTextboxLogin;
        private Button LoginButton;
        private Button SignupButton;
        private TextBox UsernameTextboxSignup;
        private TextBox EmailTextbox;
        private TextBox LastnameTextbox;
        private TextBox FirstnameTextbox;
        private Label PasswordLabelSignup;
        private Label UsernameLabelSignup;
        private Label LastnameLabel;
        private Label FirstnameLabel;
        private CheckBox TermsAndConditionsCheckbox;
        private TextBox PasswordTextboxSignup;
        private Label EmailLabelSignup;
        private LinkLabel TermsAndConditionsLink;
        private Panel UsernameBackgroundLogin;
        private Panel PasswordBackgroundLogin;
        private PictureBox PasswordIconLogin;
        private PictureBox UsernameIconLogin;
        private PictureBox PasswordHide;
        private Panel PanelBackgroundLoginSignup;
        private PictureBox PasswordShow;
        private PictureBox BackgroundLoginSignup;
    }
}