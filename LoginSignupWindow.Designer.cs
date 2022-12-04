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
            this.loginSignupTabControl = new System.Windows.Forms.TabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.usernameLabelLogin = new System.Windows.Forms.Label();
            this.passwordLabelLogin = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.passwordTextboxLogin = new System.Windows.Forms.TextBox();
            this.usernameTextboxLogin = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpPage = new System.Windows.Forms.TabPage();
            this.usernameTextboxSignup = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabelSignup = new System.Windows.Forms.Label();
            this.usernameLabelSignup = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.continueWithoutAccountButton = new System.Windows.Forms.Button();
            this.elenchosLabel = new System.Windows.Forms.Label();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.emailLabelSignup = new System.Windows.Forms.Label();
            this.passwordTextboxSignup = new System.Windows.Forms.TextBox();
            this.termsAndConditionsCheckbox = new System.Windows.Forms.CheckBox();
            this.termsAndConditionsLink = new System.Windows.Forms.LinkLabel();
            this.loginSignupTabControl.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.signUpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginSignupTabControl
            // 
            this.loginSignupTabControl.Controls.Add(this.loginPage);
            this.loginSignupTabControl.Controls.Add(this.signUpPage);
            this.loginSignupTabControl.Location = new System.Drawing.Point(12, 74);
            this.loginSignupTabControl.Name = "loginSignupTabControl";
            this.loginSignupTabControl.SelectedIndex = 0;
            this.loginSignupTabControl.Size = new System.Drawing.Size(425, 324);
            this.loginSignupTabControl.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.usernameLabelLogin);
            this.loginPage.Controls.Add(this.passwordLabelLogin);
            this.loginPage.Controls.Add(this.forgotPasswordLink);
            this.loginPage.Controls.Add(this.passwordTextboxLogin);
            this.loginPage.Controls.Add(this.usernameTextboxLogin);
            this.loginPage.Controls.Add(this.loginButton);
            this.loginPage.Location = new System.Drawing.Point(4, 24);
            this.loginPage.Name = "loginPage";
            this.loginPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginPage.Size = new System.Drawing.Size(417, 296);
            this.loginPage.TabIndex = 0;
            this.loginPage.Text = "Login";
            this.loginPage.UseVisualStyleBackColor = true;
            // 
            // usernameLabelLogin
            // 
            this.usernameLabelLogin.AutoSize = true;
            this.usernameLabelLogin.Location = new System.Drawing.Point(81, 80);
            this.usernameLabelLogin.Name = "usernameLabelLogin";
            this.usernameLabelLogin.Size = new System.Drawing.Size(69, 15);
            this.usernameLabelLogin.TabIndex = 4;
            this.usernameLabelLogin.Text = "Username : ";
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.Location = new System.Drawing.Point(81, 144);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(63, 15);
            this.passwordLabelLogin.TabIndex = 4;
            this.passwordLabelLogin.Text = "Password :";
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Location = new System.Drawing.Point(81, 188);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(100, 15);
            this.forgotPasswordLink.TabIndex = 3;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            // 
            // passwordTextboxLogin
            // 
            this.passwordTextboxLogin.Location = new System.Drawing.Point(81, 162);
            this.passwordTextboxLogin.Name = "passwordTextboxLogin";
            this.passwordTextboxLogin.Size = new System.Drawing.Size(268, 23);
            this.passwordTextboxLogin.TabIndex = 2;
            // 
            // usernameTextboxLogin
            // 
            this.usernameTextboxLogin.Location = new System.Drawing.Point(81, 98);
            this.usernameTextboxLogin.Name = "usernameTextboxLogin";
            this.usernameTextboxLogin.Size = new System.Drawing.Size(268, 23);
            this.usernameTextboxLogin.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(11, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(395, 39);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Let\'s go !!";
            this.loginButton.UseVisualStyleBackColor = true;
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
            this.signUpPage.Location = new System.Drawing.Point(4, 24);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Padding = new System.Windows.Forms.Padding(3);
            this.signUpPage.Size = new System.Drawing.Size(417, 296);
            this.signUpPage.TabIndex = 1;
            this.signUpPage.Text = "Sign up";
            this.signUpPage.UseVisualStyleBackColor = true;
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
            this.passwordLabelSignup.Click += new System.EventHandler(this.passwordLabelSignup_Click);
            // 
            // usernameLabelSignup
            // 
            this.usernameLabelSignup.AutoSize = true;
            this.usernameLabelSignup.Location = new System.Drawing.Point(32, 122);
            this.usernameLabelSignup.Name = "usernameLabelSignup";
            this.usernameLabelSignup.Size = new System.Drawing.Size(66, 15);
            this.usernameLabelSignup.TabIndex = 1;
            this.usernameLabelSignup.Text = "Username :";
            this.usernameLabelSignup.Click += new System.EventHandler(this.usernameLabelSignup_Click);
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
            this.signupButton.Location = new System.Drawing.Point(6, 253);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(405, 37);
            this.signupButton.TabIndex = 0;
            this.signupButton.Text = "Sign me up!";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // continueWithoutAccountButton
            // 
            this.continueWithoutAccountButton.Location = new System.Drawing.Point(16, 404);
            this.continueWithoutAccountButton.Name = "continueWithoutAccountButton";
            this.continueWithoutAccountButton.Size = new System.Drawing.Size(417, 36);
            this.continueWithoutAccountButton.TabIndex = 1;
            this.continueWithoutAccountButton.Text = "Continue without Account";
            this.continueWithoutAccountButton.UseVisualStyleBackColor = true;
            // 
            // elenchosLabel
            // 
            this.elenchosLabel.AutoSize = true;
            this.elenchosLabel.Location = new System.Drawing.Point(195, 16);
            this.elenchosLabel.Name = "elenchosLabel";
            this.elenchosLabel.Size = new System.Drawing.Size(54, 15);
            this.elenchosLabel.TabIndex = 2;
            this.elenchosLabel.Text = "Elenchos";
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quoteLabel.Location = new System.Drawing.Point(141, 34);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(170, 21);
            this.quoteLabel.TabIndex = 2;
            this.quoteLabel.Text = "\"Time waits on no one\"";
            this.quoteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // passwordTextboxSignup
            // 
            this.passwordTextboxSignup.Location = new System.Drawing.Point(33, 185);
            this.passwordTextboxSignup.Name = "passwordTextboxSignup";
            this.passwordTextboxSignup.Size = new System.Drawing.Size(352, 23);
            this.passwordTextboxSignup.TabIndex = 2;
            // 
            // termsAndConditionsCheckbox
            // 
            this.termsAndConditionsCheckbox.AutoSize = true;
            this.termsAndConditionsCheckbox.Location = new System.Drawing.Point(64, 228);
            this.termsAndConditionsCheckbox.Name = "termsAndConditionsCheckbox";
            this.termsAndConditionsCheckbox.Size = new System.Drawing.Size(98, 19);
            this.termsAndConditionsCheckbox.TabIndex = 3;
            this.termsAndConditionsCheckbox.Text = "I agree to the ";
            this.termsAndConditionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // termsAndConditionsLink
            // 
            this.termsAndConditionsLink.AutoSize = true;
            this.termsAndConditionsLink.Location = new System.Drawing.Point(153, 229);
            this.termsAndConditionsLink.Name = "termsAndConditionsLink";
            this.termsAndConditionsLink.Size = new System.Drawing.Size(119, 15);
            this.termsAndConditionsLink.TabIndex = 4;
            this.termsAndConditionsLink.TabStop = true;
            this.termsAndConditionsLink.Text = "terms and conditions";
            // 
            // LoginSignupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 452);
            this.Controls.Add(this.quoteLabel);
            this.Controls.Add(this.elenchosLabel);
            this.Controls.Add(this.continueWithoutAccountButton);
            this.Controls.Add(this.loginSignupTabControl);
            this.Name = "LoginSignupWindow";
            this.Text = "Login/Signup";
            this.loginSignupTabControl.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.signUpPage.ResumeLayout(false);
            this.signUpPage.PerformLayout();
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
    }
}