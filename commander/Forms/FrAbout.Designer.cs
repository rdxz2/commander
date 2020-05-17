namespace commander.Forms
{
    partial class FrAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.llblHowToUse = new System.Windows.Forms.LinkLabel();
            this.llblAppVersion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 43);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Commander";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(101, 52);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(65, 17);
            this.lblCreator.TabIndex = 6;
            this.lblCreator.Text = "by: rdxz2";
            // 
            // llblHowToUse
            // 
            this.llblHowToUse.AutoSize = true;
            this.llblHowToUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblHowToUse.Location = new System.Drawing.Point(77, 147);
            this.llblHowToUse.Name = "llblHowToUse";
            this.llblHowToUse.Size = new System.Drawing.Size(112, 20);
            this.llblHowToUse.TabIndex = 9;
            this.llblHowToUse.TabStop = true;
            this.llblHowToUse.Text = "How To Use";
            this.llblHowToUse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblHowToUse_LinkClicked);
            // 
            // llblAppVersion
            // 
            this.llblAppVersion.AutoSize = true;
            this.llblAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAppVersion.Location = new System.Drawing.Point(60, 69);
            this.llblAppVersion.Name = "llblAppVersion";
            this.llblAppVersion.Size = new System.Drawing.Size(147, 17);
            this.llblAppVersion.TabIndex = 10;
            this.llblAppVersion.TabStop = true;
            this.llblAppVersion.Text = "{linkLabelAppVersion}";
            this.llblAppVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llblAppVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LllblAppVersion_LinkClicked);
            // 
            // FrAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 196);
            this.Controls.Add(this.llblAppVersion);
            this.Controls.Add(this.llblHowToUse);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrAbout";
            this.Text = "FrAbout";
            this.Load += new System.EventHandler(this.FrAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.LinkLabel llblHowToUse;
        private System.Windows.Forms.LinkLabel llblAppVersion;
    }
}