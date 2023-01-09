namespace Elenchos
{
    partial class LoadingScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.LoadingAnimation = new ReaLTaiizor.Controls.HopePictureBox();
            this.LoadingText = new ReaLTaiizor.Controls.BigLabel();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingAnimation
            // 
            this.LoadingAnimation.BackColor = System.Drawing.Color.Transparent;
            this.LoadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("LoadingAnimation.Image")));
            this.LoadingAnimation.Location = new System.Drawing.Point(161, 109);
            this.LoadingAnimation.Name = "LoadingAnimation";
            this.LoadingAnimation.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.LoadingAnimation.Size = new System.Drawing.Size(250, 250);
            this.LoadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingAnimation.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.LoadingAnimation.TabIndex = 0;
            this.LoadingAnimation.TabStop = false;
            this.LoadingAnimation.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // LoadingText
            // 
            this.LoadingText.AutoSize = true;
            this.LoadingText.BackColor = System.Drawing.Color.Transparent;
            this.LoadingText.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LoadingText.Location = new System.Drawing.Point(187, 362);
            this.LoadingText.Name = "LoadingText";
            this.LoadingText.Size = new System.Drawing.Size(179, 46);
            this.LoadingText.TabIndex = 1;
            this.LoadingText.Text = "Logging in";
            this.LoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Interval = 1000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 615);
            this.Controls.Add(this.LoadingText);
            this.Controls.Add(this.LoadingAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(582, 615);
            this.MinimumSize = new System.Drawing.Size(582, 615);
            this.Name = "LoadingScreen";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.LoadingAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HopePictureBox LoadingAnimation;
        private ReaLTaiizor.Controls.BigLabel LoadingText;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}