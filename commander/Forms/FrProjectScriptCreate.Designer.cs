namespace commander.Forms
{
    partial class FrProjectScriptCreate
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxScript = new System.Windows.Forms.TextBox();
            this.lblScript = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Script name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(15, 29);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(280, 22);
            this.tbxName.TabIndex = 1;
            // 
            // tbxScript
            // 
            this.tbxScript.Location = new System.Drawing.Point(15, 74);
            this.tbxScript.Multiline = true;
            this.tbxScript.Name = "tbxScript";
            this.tbxScript.Size = new System.Drawing.Size(280, 86);
            this.tbxScript.TabIndex = 2;
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Location = new System.Drawing.Point(12, 54);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(44, 17);
            this.lblScript.TabIndex = 3;
            this.lblScript.Text = "Script";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(160, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FrProjectScriptCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 202);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblScript);
            this.Controls.Add(this.tbxScript);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrProjectScriptCreate";
            this.Text = "Create script";
            this.Load += new System.EventHandler(this.FrProjectScriptCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxScript;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}