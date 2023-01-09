namespace Elenchos
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainWindowControlPanel = new ReaLTaiizor.Controls.Panel();
            this.MainWindowControlBox = new ReaLTaiizor.Controls.ControlBox();
            this.SearchBox = new ReaLTaiizor.Controls.SmallTextBox();
            this.SidePanel = new ReaLTaiizor.Controls.Panel();
            this.SideBarSubPanel = new System.Windows.Forms.Panel();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.AccountAndSettingsButton = new System.Windows.Forms.PictureBox();
            this.WeekViewButton = new System.Windows.Forms.Button();
            this.MonthViewButton = new System.Windows.Forms.Button();
            this.SaturdayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.FridayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.WednesdayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.ThurdayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.TuesdayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.MondayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.SundayButton = new ReaLTaiizor.Controls.RoyalButton();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.PanelSeparator = new ReaLTaiizor.Controls.Panel();
            this.MainWindowControlPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SideBarSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountAndSettingsButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowControlPanel
            // 
            this.MainWindowControlPanel.BackColor = System.Drawing.Color.White;
            this.MainWindowControlPanel.Controls.Add(this.MainWindowControlBox);
            this.MainWindowControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainWindowControlPanel.EdgeColor = System.Drawing.Color.White;
            this.MainWindowControlPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindowControlPanel.Name = "MainWindowControlPanel";
            this.MainWindowControlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainWindowControlPanel.Size = new System.Drawing.Size(1000, 33);
            this.MainWindowControlPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.MainWindowControlPanel.TabIndex = 1;
            this.MainWindowControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowControlPanel_MouseDown);
            // 
            // MainWindowControlBox
            // 
            this.MainWindowControlBox.BackColor = System.Drawing.Color.White;
            this.MainWindowControlBox.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.MainWindowControlBox.DefaultLocation = true;
            this.MainWindowControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainWindowControlBox.EnableHoverHighlight = true;
            this.MainWindowControlBox.EnableMaximizeButton = true;
            this.MainWindowControlBox.EnableMinimizeButton = true;
            this.MainWindowControlBox.ForeColor = System.Drawing.Color.Black;
            this.MainWindowControlBox.Location = new System.Drawing.Point(905, 5);
            this.MainWindowControlBox.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.MainWindowControlBox.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MainWindowControlBox.Name = "MainWindowControlBox";
            this.MainWindowControlBox.Size = new System.Drawing.Size(90, 25);
            this.MainWindowControlBox.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SearchBox.CustomBGColor = System.Drawing.Color.White;
            this.SearchBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.ForeColor = System.Drawing.Color.DimGray;
            this.SearchBox.Location = new System.Drawing.Point(52, 14);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ReadOnly = false;
            this.SearchBox.Size = new System.Drawing.Size(219, 28);
            this.SearchBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Text = "Search ...";
            this.SearchBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBox.UseSystemPasswordChar = false;
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.AutoScroll = true;
            this.SidePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SidePanel.Controls.Add(this.SideBarSubPanel);
            this.SidePanel.Controls.Add(this.SaturdayButton);
            this.SidePanel.Controls.Add(this.FridayButton);
            this.SidePanel.Controls.Add(this.WednesdayButton);
            this.SidePanel.Controls.Add(this.ThurdayButton);
            this.SidePanel.Controls.Add(this.TuesdayButton);
            this.SidePanel.Controls.Add(this.MondayButton);
            this.SidePanel.Controls.Add(this.SundayButton);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.EdgeColor = System.Drawing.Color.Transparent;
            this.SidePanel.Location = new System.Drawing.Point(0, 33);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(5);
            this.SidePanel.Size = new System.Drawing.Size(340, 567);
            this.SidePanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.SidePanel.TabIndex = 5;
            // 
            // SideBarSubPanel
            // 
            this.SideBarSubPanel.Controls.Add(this.SearchIcon);
            this.SideBarSubPanel.Controls.Add(this.SearchBox);
            this.SideBarSubPanel.Controls.Add(this.AccountAndSettingsButton);
            this.SideBarSubPanel.Controls.Add(this.WeekViewButton);
            this.SideBarSubPanel.Controls.Add(this.MonthViewButton);
            this.SideBarSubPanel.Location = new System.Drawing.Point(8, 8);
            this.SideBarSubPanel.Name = "SideBarSubPanel";
            this.SideBarSubPanel.Size = new System.Drawing.Size(308, 116);
            this.SideBarSubPanel.TabIndex = 11;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Location = new System.Drawing.Point(273, 15);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(25, 25);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 8;
            this.SearchIcon.TabStop = false;
            // 
            // AccountAndSettingsButton
            // 
            this.AccountAndSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountAndSettingsButton.Image")));
            this.AccountAndSettingsButton.Location = new System.Drawing.Point(6, 11);
            this.AccountAndSettingsButton.Name = "AccountAndSettingsButton";
            this.AccountAndSettingsButton.Size = new System.Drawing.Size(40, 40);
            this.AccountAndSettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountAndSettingsButton.TabIndex = 6;
            this.AccountAndSettingsButton.TabStop = false;
            // 
            // WeekViewButton
            // 
            this.WeekViewButton.BackColor = System.Drawing.Color.White;
            this.WeekViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeekViewButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeekViewButton.Location = new System.Drawing.Point(32, 76);
            this.WeekViewButton.Name = "WeekViewButton";
            this.WeekViewButton.Size = new System.Drawing.Size(127, 29);
            this.WeekViewButton.TabIndex = 7;
            this.WeekViewButton.Text = "Week";
            this.WeekViewButton.UseVisualStyleBackColor = false;
            this.WeekViewButton.Click += new System.EventHandler(this.WeekViewButton_Click);
            // 
            // MonthViewButton
            // 
            this.MonthViewButton.BackColor = System.Drawing.Color.White;
            this.MonthViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthViewButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthViewButton.Location = new System.Drawing.Point(159, 76);
            this.MonthViewButton.Name = "MonthViewButton";
            this.MonthViewButton.Size = new System.Drawing.Size(127, 29);
            this.MonthViewButton.TabIndex = 7;
            this.MonthViewButton.Text = "Month";
            this.MonthViewButton.UseVisualStyleBackColor = false;
            this.MonthViewButton.Click += new System.EventHandler(this.MonthViewButton_Click);
            // 
            // SaturdayButton
            // 
            this.SaturdayButton.BackColor = System.Drawing.Color.White;
            this.SaturdayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SaturdayButton.BorderThickness = 3;
            this.SaturdayButton.DrawBorder = true;
            this.SaturdayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaturdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SaturdayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.SaturdayButton.Image = null;
            this.SaturdayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.SaturdayButton.Location = new System.Drawing.Point(17, 461);
            this.SaturdayButton.Name = "SaturdayButton";
            this.SaturdayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.SaturdayButton.PressedForeColor = System.Drawing.Color.White;
            this.SaturdayButton.Size = new System.Drawing.Size(293, 40);
            this.SaturdayButton.TabIndex = 10;
            this.SaturdayButton.Text = "Saturday";
            this.SaturdayButton.Click += new System.EventHandler(this.SaturdayButton_Click);
            // 
            // FridayButton
            // 
            this.FridayButton.BackColor = System.Drawing.Color.White;
            this.FridayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FridayButton.BorderThickness = 3;
            this.FridayButton.DrawBorder = true;
            this.FridayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FridayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FridayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.FridayButton.Image = null;
            this.FridayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.FridayButton.Location = new System.Drawing.Point(17, 408);
            this.FridayButton.Name = "FridayButton";
            this.FridayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.FridayButton.PressedForeColor = System.Drawing.Color.White;
            this.FridayButton.Size = new System.Drawing.Size(293, 40);
            this.FridayButton.TabIndex = 10;
            this.FridayButton.Text = "Friday";
            this.FridayButton.Click += new System.EventHandler(this.FridayButton_Click);
            // 
            // WednesdayButton
            // 
            this.WednesdayButton.BackColor = System.Drawing.Color.White;
            this.WednesdayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.WednesdayButton.BorderThickness = 3;
            this.WednesdayButton.DrawBorder = true;
            this.WednesdayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WednesdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WednesdayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.WednesdayButton.Image = null;
            this.WednesdayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.WednesdayButton.Location = new System.Drawing.Point(17, 300);
            this.WednesdayButton.Name = "WednesdayButton";
            this.WednesdayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.WednesdayButton.PressedForeColor = System.Drawing.Color.White;
            this.WednesdayButton.Size = new System.Drawing.Size(293, 40);
            this.WednesdayButton.TabIndex = 10;
            this.WednesdayButton.Text = "Wednesday";
            this.WednesdayButton.Click += new System.EventHandler(this.WednesdayButton_Click);
            // 
            // ThurdayButton
            // 
            this.ThurdayButton.BackColor = System.Drawing.Color.White;
            this.ThurdayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ThurdayButton.BorderThickness = 3;
            this.ThurdayButton.DrawBorder = true;
            this.ThurdayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThurdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ThurdayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ThurdayButton.Image = null;
            this.ThurdayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.ThurdayButton.Location = new System.Drawing.Point(17, 354);
            this.ThurdayButton.Name = "ThurdayButton";
            this.ThurdayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ThurdayButton.PressedForeColor = System.Drawing.Color.White;
            this.ThurdayButton.Size = new System.Drawing.Size(293, 40);
            this.ThurdayButton.TabIndex = 10;
            this.ThurdayButton.Text = "Thurday";
            this.ThurdayButton.Click += new System.EventHandler(this.ThurdayButton_Click);
            // 
            // TuesdayButton
            // 
            this.TuesdayButton.BackColor = System.Drawing.Color.White;
            this.TuesdayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TuesdayButton.BorderThickness = 3;
            this.TuesdayButton.DrawBorder = true;
            this.TuesdayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TuesdayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TuesdayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.TuesdayButton.Image = null;
            this.TuesdayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.TuesdayButton.Location = new System.Drawing.Point(17, 246);
            this.TuesdayButton.Name = "TuesdayButton";
            this.TuesdayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.TuesdayButton.PressedForeColor = System.Drawing.Color.White;
            this.TuesdayButton.Size = new System.Drawing.Size(293, 40);
            this.TuesdayButton.TabIndex = 10;
            this.TuesdayButton.Text = "Tuesday";
            this.TuesdayButton.Click += new System.EventHandler(this.TuesdayButton_Click);
            // 
            // MondayButton
            // 
            this.MondayButton.BackColor = System.Drawing.Color.White;
            this.MondayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MondayButton.BorderThickness = 3;
            this.MondayButton.DrawBorder = true;
            this.MondayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MondayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MondayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.MondayButton.Image = null;
            this.MondayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.MondayButton.Location = new System.Drawing.Point(17, 192);
            this.MondayButton.Name = "MondayButton";
            this.MondayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.MondayButton.PressedForeColor = System.Drawing.Color.White;
            this.MondayButton.Size = new System.Drawing.Size(293, 40);
            this.MondayButton.TabIndex = 10;
            this.MondayButton.Text = "Monday";
            this.MondayButton.Click += new System.EventHandler(this.MondayButton_Click);
            // 
            // SundayButton
            // 
            this.SundayButton.BackColor = System.Drawing.Color.White;
            this.SundayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SundayButton.BorderThickness = 3;
            this.SundayButton.DrawBorder = true;
            this.SundayButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SundayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SundayButton.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.SundayButton.Image = null;
            this.SundayButton.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.SundayButton.Location = new System.Drawing.Point(17, 138);
            this.SundayButton.Name = "SundayButton";
            this.SundayButton.PressedColor = System.Drawing.Color.PaleTurquoise;
            this.SundayButton.PressedForeColor = System.Drawing.Color.White;
            this.SundayButton.Size = new System.Drawing.Size(293, 40);
            this.SundayButton.TabIndex = 10;
            this.SundayButton.Text = "Sunday";
            this.SundayButton.Click += new System.EventHandler(this.SundayButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.PanelSeparator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.EdgeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(340, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(644, 567);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 6;
            this.panel1.Text = "panel1";
            // 
            // PanelSeparator
            // 
            this.PanelSeparator.BackColor = System.Drawing.Color.White;
            this.PanelSeparator.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSeparator.EdgeColor = System.Drawing.Color.Transparent;
            this.PanelSeparator.Location = new System.Drawing.Point(5, 5);
            this.PanelSeparator.MinimumSize = new System.Drawing.Size(0, 567);
            this.PanelSeparator.Name = "PanelSeparator";
            this.PanelSeparator.Padding = new System.Windows.Forms.Padding(5);
            this.PanelSeparator.Size = new System.Drawing.Size(10, 567);
            this.PanelSeparator.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PanelSeparator.TabIndex = 6;
            this.PanelSeparator.Text = "panel1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.MainWindowControlPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "MainWindow";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.MainWindowControlPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SideBarSubPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountAndSettingsButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.Panel MainWindowControlPanel;
        private ReaLTaiizor.Controls.ControlBox MainWindowControlBox;
        private ReaLTaiizor.Controls.SmallTextBox SearchBox;
        private ReaLTaiizor.Controls.Panel SidePanel;
        private ReaLTaiizor.Controls.Panel panel1;
        private PictureBox AccountAndSettingsButton;
        private Button MonthViewButton;
        private Button WeekViewButton;
        private ReaLTaiizor.Controls.Panel PanelSeparator;
        private ReaLTaiizor.Controls.RoyalButton SaturdayButton;
        private ReaLTaiizor.Controls.RoyalButton FridayButton;
        private ReaLTaiizor.Controls.RoyalButton WednesdayButton;
        private ReaLTaiizor.Controls.RoyalButton ThurdayButton;
        private ReaLTaiizor.Controls.RoyalButton TuesdayButton;
        private ReaLTaiizor.Controls.RoyalButton MondayButton;
        private ReaLTaiizor.Controls.RoyalButton SundayButton;
        private Panel SideBarSubPanel;
        private PictureBox SearchIcon;
    }
}