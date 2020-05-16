﻿namespace commander.Forms
{
    partial class FrHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrHome));
            this.lbxProjects = new System.Windows.Forms.ListBox();
            this.bindsrcProject = new System.Windows.Forms.BindingSource(this.components);
            this.btnProjectAdd = new System.Windows.Forms.Button();
            this.btnProjectRemove = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPojects = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.dgvProjectScripts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastExecuted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBindsrcProjectScripts = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnProjectScriptAdd = new System.Windows.Forms.Button();
            this.btnProjectScriptRemove = new System.Windows.Forms.Button();
            this.lblProjectScripts = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindsrcProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectScripts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindsrcProjectScripts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxProjects
            // 
            this.lbxProjects.DataSource = this.bindsrcProject;
            this.lbxProjects.DisplayMember = "Name";
            this.lbxProjects.FormattingEnabled = true;
            this.lbxProjects.ItemHeight = 16;
            this.lbxProjects.Location = new System.Drawing.Point(12, 110);
            this.lbxProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxProjects.Name = "lbxProjects";
            this.lbxProjects.Size = new System.Drawing.Size(155, 292);
            this.lbxProjects.TabIndex = 0;
            this.lbxProjects.SelectedIndexChanged += new System.EventHandler(this.LbxProjects_SelectedIndexChanged);
            // 
            // bindsrcProject
            // 
            this.bindsrcProject.DataSource = typeof(commander.ViewModels.VMHome.Project);
            // 
            // btnProjectAdd
            // 
            this.btnProjectAdd.Location = new System.Drawing.Point(12, 80);
            this.btnProjectAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProjectAdd.Name = "btnProjectAdd";
            this.btnProjectAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProjectAdd.TabIndex = 1;
            this.btnProjectAdd.Text = "Add";
            this.btnProjectAdd.UseVisualStyleBackColor = true;
            this.btnProjectAdd.Click += new System.EventHandler(this.BtnProjectAdd_Click);
            // 
            // btnProjectRemove
            // 
            this.btnProjectRemove.Enabled = false;
            this.btnProjectRemove.Location = new System.Drawing.Point(93, 80);
            this.btnProjectRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProjectRemove.Name = "btnProjectRemove";
            this.btnProjectRemove.Size = new System.Drawing.Size(75, 23);
            this.btnProjectRemove.TabIndex = 2;
            this.btnProjectRemove.Text = "Remove";
            this.btnProjectRemove.UseVisualStyleBackColor = true;
            this.btnProjectRemove.Click += new System.EventHandler(this.BtnProjectRemove_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 43);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Commander";
            // 
            // lblPojects
            // 
            this.lblPojects.AutoSize = true;
            this.lblPojects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPojects.Location = new System.Drawing.Point(7, 52);
            this.lblPojects.Name = "lblPojects";
            this.lblPojects.Size = new System.Drawing.Size(126, 25);
            this.lblPojects.TabIndex = 4;
            this.lblPojects.Text = "Your projects";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(275, 9);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(65, 17);
            this.lblCreator.TabIndex = 5;
            this.lblCreator.Text = "by: rdxz2";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.Location = new System.Drawing.Point(275, 27);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(121, 17);
            this.lblAppVersion.TabIndex = 6;
            this.lblAppVersion.Text = "{labelAppVersion}";
            // 
            // dgvProjectScripts
            // 
            this.dgvProjectScripts.AllowDrop = true;
            this.dgvProjectScripts.AllowUserToAddRows = false;
            this.dgvProjectScripts.AllowUserToDeleteRows = false;
            this.dgvProjectScripts.AutoGenerateColumns = false;
            this.dgvProjectScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectScripts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.scriptDataGridViewTextBoxColumn,
            this.LastExecuted,
            this.Pid});
            this.dgvProjectScripts.DataSource = this.dgvBindsrcProjectScripts;
            this.dgvProjectScripts.Location = new System.Drawing.Point(188, 80);
            this.dgvProjectScripts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProjectScripts.MultiSelect = false;
            this.dgvProjectScripts.Name = "dgvProjectScripts";
            this.dgvProjectScripts.RowTemplate.Height = 24;
            this.dgvProjectScripts.Size = new System.Drawing.Size(1013, 321);
            this.dgvProjectScripts.TabIndex = 7;
            this.dgvProjectScripts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectScripts_CellDoubleClick);
            this.dgvProjectScripts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectScripts_CellEndEdit);
            this.dgvProjectScripts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProjectScripts_CellMouseDown);
            this.dgvProjectScripts.SelectionChanged += new System.EventHandler(this.DgvProjectScripts_SelectionChanged);
            this.dgvProjectScripts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DgvProjectScripts_MouseMove);
            this.dgvProjectScripts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgvProjectScripts_MouseUp);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // scriptDataGridViewTextBoxColumn
            // 
            this.scriptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scriptDataGridViewTextBoxColumn.DataPropertyName = "Script";
            this.scriptDataGridViewTextBoxColumn.HeaderText = "Script";
            this.scriptDataGridViewTextBoxColumn.Name = "scriptDataGridViewTextBoxColumn";
            // 
            // LastExecuted
            // 
            this.LastExecuted.DataPropertyName = "LastExecuted";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.LastExecuted.DefaultCellStyle = dataGridViewCellStyle1;
            this.LastExecuted.FillWeight = 120F;
            this.LastExecuted.HeaderText = "LastExecuted";
            this.LastExecuted.Name = "LastExecuted";
            this.LastExecuted.ReadOnly = true;
            this.LastExecuted.Width = 120;
            // 
            // Pid
            // 
            this.Pid.DataPropertyName = "Pid";
            this.Pid.FillWeight = 70F;
            this.Pid.HeaderText = "Pid";
            this.Pid.Name = "Pid";
            this.Pid.ReadOnly = true;
            this.Pid.Width = 70;
            // 
            // dgvBindsrcProjectScripts
            // 
            this.dgvBindsrcProjectScripts.DataSource = typeof(commander.ViewModels.VMHome.ProjectScript);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnProjectScriptAdd
            // 
            this.btnProjectScriptAdd.Location = new System.Drawing.Point(1047, 52);
            this.btnProjectScriptAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProjectScriptAdd.Name = "btnProjectScriptAdd";
            this.btnProjectScriptAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProjectScriptAdd.TabIndex = 8;
            this.btnProjectScriptAdd.Text = "Add";
            this.btnProjectScriptAdd.UseVisualStyleBackColor = true;
            this.btnProjectScriptAdd.Click += new System.EventHandler(this.BtnProjectScriptAdd_Click);
            // 
            // btnProjectScriptRemove
            // 
            this.btnProjectScriptRemove.Enabled = false;
            this.btnProjectScriptRemove.Location = new System.Drawing.Point(1127, 52);
            this.btnProjectScriptRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProjectScriptRemove.Name = "btnProjectScriptRemove";
            this.btnProjectScriptRemove.Size = new System.Drawing.Size(75, 23);
            this.btnProjectScriptRemove.TabIndex = 9;
            this.btnProjectScriptRemove.Text = "Remove";
            this.btnProjectScriptRemove.UseVisualStyleBackColor = true;
            this.btnProjectScriptRemove.Click += new System.EventHandler(this.BtnProjectScriptRemove_Click);
            // 
            // lblProjectScripts
            // 
            this.lblProjectScripts.AutoSize = true;
            this.lblProjectScripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectScripts.Location = new System.Drawing.Point(183, 52);
            this.lblProjectScripts.Name = "lblProjectScripts";
            this.lblProjectScripts.Size = new System.Drawing.Size(187, 25);
            this.lblProjectScripts.TabIndex = 10;
            this.lblProjectScripts.Text = "{labelProjectScripts}";
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(1132, 9);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 32);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Location = new System.Drawing.Point(1169, 9);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // FrHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 414);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblProjectScripts);
            this.Controls.Add(this.btnProjectScriptRemove);
            this.Controls.Add(this.btnProjectScriptAdd);
            this.Controls.Add(this.dgvProjectScripts);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblPojects);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnProjectRemove);
            this.Controls.Add(this.btnProjectAdd);
            this.Controls.Add(this.lbxProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrHome";
            this.Text = "Commander by: rdxz2";
            this.Load += new System.EventHandler(this.FrHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindsrcProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectScripts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindsrcProjectScripts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProjects;
        private System.Windows.Forms.Button btnProjectAdd;
        private System.Windows.Forms.Button btnProjectRemove;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPojects;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.DataGridView dgvProjectScripts;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnProjectScriptAdd;
        private System.Windows.Forms.Button btnProjectScriptRemove;
        private System.Windows.Forms.Label lblProjectScripts;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastExecuted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
        private System.Windows.Forms.BindingSource dgvBindsrcProjectScripts;
        private System.Windows.Forms.BindingSource bindsrcProject;
    }
}