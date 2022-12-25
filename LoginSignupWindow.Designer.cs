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
            this.loginSignupTabControl = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameLabelLogin = new System.Windows.Forms.Label();
            this.passwordLabelLogin = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameTextboxLogin = new System.Windows.Forms.TextBox();
            this.passwordTextboxLogin = new System.Windows.Forms.TextBox();
            this.signUpPage = new System.Windows.Forms.TabPage();
            this.termsAndConditionsLink = new System.Windows.Forms.LinkLabel();
            this.termsAndConditionsCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordTextboxSignup = new System.Windows.Forms.TextBox();
            this.usernameTextboxSignup = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.emailLabelSignup = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabelSignup = new System.Windows.Forms.Label();
            this.usernameLabelSignup = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.continueWithoutAccountButton = new System.Windows.Forms.Button();
            this.elenchosLabel = new System.Windows.Forms.Label();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loginSignupTabControl.SuspendLayout();
            this.loginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.signUpPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginSignupTabControl
            // 
            this.loginSignupTabControl.Controls.Add(this.loginPage);
            this.loginSignupTabControl.Controls.Add(this.signUpPage);
            this.loginSignupTabControl.Location = new System.Drawing.Point(259, 133);
            this.loginSignupTabControl.Name = "loginSignupTabControl";
            this.loginSignupTabControl.Padding = new System.Drawing.Point(90, 5);
            this.loginSignupTabControl.SelectedIndex = 0;
            this.loginSignupTabControl.Size = new System.Drawing.Size(439, 337);
            this.loginSignupTabControl.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.Transparent;
            this.loginPage.Controls.Add(this.pictureBox3);
            this.loginPage.Controls.Add(this.pictureBox2);
            this.loginPage.Controls.Add(this.usernameLabelLogin);
            this.loginPage.Controls.Add(this.passwordLabelLogin);
            this.loginPage.Controls.Add(this.forgotPasswordLink);
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Controls.Add(this.panel2);
            this.loginPage.Controls.Add(this.panel1);
            this.loginPage.Controls.Add(this.passwordTextboxLogin);
            this.loginPage.Location = new System.Drawing.Point(4, 28);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(431, 305);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(72, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // usernameLabelLogin
            // 
            this.usernameLabelLogin.AutoSize = true;
            this.usernameLabelLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabelLogin.Location = new System.Drawing.Point(95, 74);
            this.usernameLabelLogin.Name = "usernameLabelLogin";
            this.usernameLabelLogin.Size = new System.Drawing.Size(78, 19);
            this.usernameLabelLogin.TabIndex = 4;
            this.usernameLabelLogin.Text = "Username: ";
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabelLogin.Location = new System.Drawing.Point(96, 137);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(70, 19);
            this.passwordLabelLogin.TabIndex = 4;
            this.passwordLabelLogin.Text = "Password:";
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Location = new System.Drawing.Point(74, 205);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(100, 15);
            this.forgotPasswordLink.TabIndex = 3;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(9, 248);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(414, 39);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Let\'s go !!";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(74, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 32);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(253, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 16);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usernameTextboxLogin);
            this.panel1.Location = new System.Drawing.Point(75, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 32);
            this.panel1.TabIndex = 5;
            // 
            // usernameTextboxLogin
            // 
            this.usernameTextboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextboxLogin.Location = new System.Drawing.Point(7, 7);
            this.usernameTextboxLogin.Name = "usernameTextboxLogin";
            this.usernameTextboxLogin.Size = new System.Drawing.Size(268, 16);
            this.usernameTextboxLogin.TabIndex = 1;
            // 
            // passwordTextboxLogin
            // 
            this.passwordTextboxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextboxLogin.Location = new System.Drawing.Point(75, 167);
            this.passwordTextboxLogin.Name = "passwordTextboxLogin";
            this.passwordTextboxLogin.Size = new System.Drawing.Size(268, 16);
            this.passwordTextboxLogin.TabIndex = 2;
            // 
            // signUpPage
            // 
            this.signUpPage.Controls.Add(this.termsAndConditionsLink);
            this.signUpPage.Controls.Add(this.termsAndConditionsCheckbox);
            this.signUpPage.Controls.Add(this.passwordTextboxSignup);
            this.signUpPage.Controls.Add(this.usernameTextboxSignup);
            this.signUpPage.Controls.Add(this.emailTextbox);
            this.signUpPage.Controls.Add(this.lastnameTextbox);
            this.signUpPage.Controls.Add(this.emailLabelSignup);
            this.signUpPage.Controls.Add(this.firstnameTextbox);
            this.signUpPage.Controls.Add(this.passwordLabelSignup);
            this.signUpPage.Controls.Add(this.usernameLabelSignup);
            this.signUpPage.Controls.Add(this.lastNameLabel);
            this.signUpPage.Controls.Add(this.firstNameLabel);
            this.signUpPage.Controls.Add(this.signupButton);
            this.signUpPage.Location = new System.Drawing.Point(4, 28);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Padding = new System.Windows.Forms.Padding(3);
            this.signUpPage.Size = new System.Drawing.Size(431, 305);
            this.signUpPage.TabIndex = 1;
            this.signUpPage.Text = "Sign up";
            this.signUpPage.UseVisualStyleBackColor = true;
            // 
            // termsAndConditionsLink
            // 
            this.termsAndConditionsLink.AutoSize = true;
            this.termsAndConditionsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.termsAndConditionsLink.Location = new System.Drawing.Point(123, 226);
            this.termsAndConditionsLink.Name = "termsAndConditionsLink";
            this.termsAndConditionsLink.Size = new System.Drawing.Size(119, 15);
            this.termsAndConditionsLink.TabIndex = 4;
            this.termsAndConditionsLink.TabStop = true;
            this.termsAndConditionsLink.Text = "terms and conditions";
            // 
            // termsAndConditionsCheckbox
            // 
            this.termsAndConditionsCheckbox.AutoSize = true;
            this.termsAndConditionsCheckbox.Location = new System.Drawing.Point(34, 225);
            this.termsAndConditionsCheckbox.Name = "termsAndConditionsCheckbox";
            this.termsAndConditionsCheckbox.Size = new System.Drawing.Size(98, 19);
            this.termsAndConditionsCheckbox.TabIndex = 3;
            this.termsAndConditionsCheckbox.Text = "I agree to the ";
            this.termsAndConditionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // passwordTextboxSignup
            // 
            this.passwordTextboxSignup.Location = new System.Drawing.Point(33, 185);
            this.passwordTextboxSignup.Name = "passwordTextboxSignup";
            this.passwordTextboxSignup.Size = new System.Drawing.Size(352, 23);
            this.passwordTextboxSignup.TabIndex = 2;
            // 
            // usernameTextboxSignup
            // 
            this.usernameTextboxSignup.Location = new System.Drawing.Point(33, 139);
            this.usernameTextboxSignup.Name = "usernameTextboxSignup";
            this.usernameTextboxSignup.Size = new System.Drawing.Size(352, 23);
            this.usernameTextboxSignup.TabIndex = 2;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(33, 94);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(352, 23);
            this.emailTextbox.TabIndex = 2;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(221, 41);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(164, 23);
            this.lastnameTextbox.TabIndex = 2;
            // 
            // emailLabelSignup
            // 
            this.emailLabelSignup.AutoSize = true;
            this.emailLabelSignup.Location = new System.Drawing.Point(33, 76);
            this.emailLabelSignup.Name = "emailLabelSignup";
            this.emailLabelSignup.Size = new System.Drawing.Size(42, 15);
            this.emailLabelSignup.TabIndex = 1;
            this.emailLabelSignup.Text = "Email :";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(33, 41);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(159, 23);
            this.firstnameTextbox.TabIndex = 2;
            // 
            // passwordLabelSignup
            // 
            this.passwordLabelSignup.AutoSize = true;
            this.passwordLabelSignup.Location = new System.Drawing.Point(33, 167);
            this.passwordLabelSignup.Name = "passwordLabelSignup";
            this.passwordLabelSignup.Size = new System.Drawing.Size(63, 15);
            this.passwordLabelSignup.TabIndex = 1;
            this.passwordLabelSignup.Text = "Password :";
            // 
            // usernameLabelSignup
            // 
            this.usernameLabelSignup.AutoSize = true;
            this.usernameLabelSignup.Location = new System.Drawing.Point(32, 122);
            this.usernameLabelSignup.Name = "usernameLabelSignup";
            this.usernameLabelSignup.Size = new System.Drawing.Size(66, 15);
            this.usernameLabelSignup.TabIndex = 1;
            this.usernameLabelSignup.Text = "Username :";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(221, 23);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(69, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(33, 23);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name :";
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signupButton.Location = new System.Drawing.Point(7, 252);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(419, 37);
            this.signupButton.TabIndex = 0;
            this.signupButton.Text = "Sign me up!";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // continueWithoutAccountButton
            // 
            this.continueWithoutAccountButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.continueWithoutAccountButton.Location = new System.Drawing.Point(53, 455);
            this.continueWithoutAccountButton.Name = "continueWithoutAccountButton";
            this.continueWithoutAccountButton.Size = new System.Drawing.Size(439, 51);
            this.continueWithoutAccountButton.TabIndex = 1;
            this.continueWithoutAccountButton.Text = "Continue without Account";
            this.continueWithoutAccountButton.UseVisualStyleBackColor = true;
            // 
            // elenchosLabel
            // 
            this.elenchosLabel.AutoSize = true;
            this.elenchosLabel.BackColor = System.Drawing.Color.Transparent;
            this.elenchosLabel.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elenchosLabel.Location = new System.Drawing.Point(195, 27);
            this.elenchosLabel.Name = "elenchosLabel";
            this.elenchosLabel.Size = new System.Drawing.Size(146, 37);
            this.elenchosLabel.TabIndex = 2;
            this.elenchosLabel.Text = "Elenchos";
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.quoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.quoteLabel.Location = new System.Drawing.Point(390, 93);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(170, 21);
            this.quoteLabel.TabIndex = 2;
            this.quoteLabel.Text = "\"Time waits on no one\"";
            this.quoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.elenchosLabel);
            this.panel3.Controls.Add(this.continueWithoutAccountButton);
            this.panel3.Location = new System.Drawing.Point(207, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 523);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // LoginSignupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(878, 576);
            this.Controls.Add(this.quoteLabel);
            this.Controls.Add(this.loginSignupTabControl);
            this.Controls.Add(this.panel3);
            this.Name = "LoginSignupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginSignupWindow_Resize);
            this.loginSignupTabControl.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.signUpPage.ResumeLayout(false);
            this.signUpPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl loginSignupTabControl;
        private TabPage loginPage;
        private TabPage signUpPage;
        private Button continueWithoutAccountButton;
        private Label elenchosLabel;
        private Label quoteLabel;
        private Label usernameLabelLogin;
        private Label passwordLabelLogin;
        private LinkLabel forgotPasswordLink;
        private TextBox passwordTextboxLogin;
        private TextBox usernameTextboxLogin;
        private Button loginButton;
        private Button signupButton;
        private TextBox usernameTextboxSignup;
        private TextBox emailTextbox;
        private TextBox lastnameTextbox;
        private TextBox firstnameTextbox;
        private Label passwordLabelSignup;
        private Label usernameLabelSignup;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private CheckBox termsAndConditionsCheckbox;
        private TextBox passwordTextboxSignup;
        private Label emailLabelSignup;
        private LinkLabel termsAndConditionsLink;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel3;
    }
}