namespace commander.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrHome));
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonProjectAdd = new System.Windows.Forms.Button();
            this.buttonProjectRemove = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPojects = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.dataGridProjectScripts = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectScriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonProjectScriptAdd = new System.Windows.Forms.Button();
            this.buttonProjectScriptRemove = new System.Windows.Forms.Button();
            this.labelProjectScripts = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectScripts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectScriptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.DataSource = this.projectBindingSource;
            this.listBoxProjects.DisplayMember = "Name";
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(12, 109);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(155, 292);
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.SelectedIndexChanged += new System.EventHandler(this.ListBoxProjects_SelectedIndexChanged);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(commander.ViewModels.VMHome.Project);
            // 
            // buttonProjectAdd
            // 
            this.buttonProjectAdd.Location = new System.Drawing.Point(12, 80);
            this.buttonProjectAdd.Name = "buttonProjectAdd";
            this.buttonProjectAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectAdd.TabIndex = 1;
            this.buttonProjectAdd.Text = "Add";
            this.buttonProjectAdd.UseVisualStyleBackColor = true;
            this.buttonProjectAdd.Click += new System.EventHandler(this.ButtonProjectAdd_Click);
            // 
            // buttonProjectRemove
            // 
            this.buttonProjectRemove.Enabled = false;
            this.buttonProjectRemove.Location = new System.Drawing.Point(93, 80);
            this.buttonProjectRemove.Name = "buttonProjectRemove";
            this.buttonProjectRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectRemove.TabIndex = 2;
            this.buttonProjectRemove.Text = "Remove";
            this.buttonProjectRemove.UseVisualStyleBackColor = true;
            this.buttonProjectRemove.Click += new System.EventHandler(this.ButtonProjectRemove_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(4, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(242, 43);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Commander";
            // 
            // labelPojects
            // 
            this.labelPojects.AutoSize = true;
            this.labelPojects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPojects.Location = new System.Drawing.Point(7, 52);
            this.labelPojects.Name = "labelPojects";
            this.labelPojects.Size = new System.Drawing.Size(126, 25);
            this.labelPojects.TabIndex = 4;
            this.labelPojects.Text = "Your projects";
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreator.Location = new System.Drawing.Point(715, 11);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(65, 17);
            this.labelCreator.TabIndex = 5;
            this.labelCreator.Text = "by: rdxz2";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppVersion.Location = new System.Drawing.Point(715, 28);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(121, 17);
            this.labelAppVersion.TabIndex = 6;
            this.labelAppVersion.Text = "{labelAppVersion}";
            // 
            // dataGridProjectScripts
            // 
            this.dataGridProjectScripts.AllowDrop = true;
            this.dataGridProjectScripts.AllowUserToAddRows = false;
            this.dataGridProjectScripts.AllowUserToDeleteRows = false;
            this.dataGridProjectScripts.AutoGenerateColumns = false;
            this.dataGridProjectScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjectScripts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.scriptDataGridViewTextBoxColumn,
            this.Pid});
            this.dataGridProjectScripts.DataSource = this.projectScriptBindingSource;
            this.dataGridProjectScripts.Location = new System.Drawing.Point(188, 109);
            this.dataGridProjectScripts.Name = "dataGridProjectScripts";
            this.dataGridProjectScripts.ReadOnly = true;
            this.dataGridProjectScripts.RowTemplate.Height = 24;
            this.dataGridProjectScripts.Size = new System.Drawing.Size(600, 292);
            this.dataGridProjectScripts.TabIndex = 7;
            this.dataGridProjectScripts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProjectScripts_CellDoubleClick);
            this.dataGridProjectScripts.SelectionChanged += new System.EventHandler(this.DataGridProjectScripts_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scriptDataGridViewTextBoxColumn
            // 
            this.scriptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scriptDataGridViewTextBoxColumn.DataPropertyName = "Script";
            this.scriptDataGridViewTextBoxColumn.HeaderText = "Script";
            this.scriptDataGridViewTextBoxColumn.Name = "scriptDataGridViewTextBoxColumn";
            this.scriptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pid
            // 
            this.Pid.DataPropertyName = "Pid";
            this.Pid.HeaderText = "Pid";
            this.Pid.Name = "Pid";
            this.Pid.ReadOnly = true;
            // 
            // projectScriptBindingSource
            // 
            this.projectScriptBindingSource.DataSource = typeof(commander.ViewModels.VMHome.ProjectScript);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonProjectScriptAdd
            // 
            this.buttonProjectScriptAdd.Location = new System.Drawing.Point(188, 80);
            this.buttonProjectScriptAdd.Name = "buttonProjectScriptAdd";
            this.buttonProjectScriptAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectScriptAdd.TabIndex = 8;
            this.buttonProjectScriptAdd.Text = "Add";
            this.buttonProjectScriptAdd.UseVisualStyleBackColor = true;
            this.buttonProjectScriptAdd.Click += new System.EventHandler(this.ButtonProjectScriptAdd_Click);
            // 
            // buttonProjectScriptRemove
            // 
            this.buttonProjectScriptRemove.Enabled = false;
            this.buttonProjectScriptRemove.Location = new System.Drawing.Point(269, 80);
            this.buttonProjectScriptRemove.Name = "buttonProjectScriptRemove";
            this.buttonProjectScriptRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonProjectScriptRemove.TabIndex = 9;
            this.buttonProjectScriptRemove.Text = "Remove";
            this.buttonProjectScriptRemove.UseVisualStyleBackColor = true;
            this.buttonProjectScriptRemove.Click += new System.EventHandler(this.ButtonProjectScriptRemove_Click);
            // 
            // labelProjectScripts
            // 
            this.labelProjectScripts.AutoSize = true;
            this.labelProjectScripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectScripts.Location = new System.Drawing.Point(183, 52);
            this.labelProjectScripts.Name = "labelProjectScripts";
            this.labelProjectScripts.Size = new System.Drawing.Size(187, 25);
            this.labelProjectScripts.TabIndex = 10;
            this.labelProjectScripts.Text = "{labelProjectScripts}";
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInfo.Location = new System.Drawing.Point(718, 71);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(32, 32);
            this.buttonInfo.TabIndex = 11;
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.BackgroundImage")));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.Location = new System.Drawing.Point(756, 71);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(32, 32);
            this.buttonSettings.TabIndex = 12;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // FrHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelProjectScripts);
            this.Controls.Add(this.buttonProjectScriptRemove);
            this.Controls.Add(this.buttonProjectScriptAdd);
            this.Controls.Add(this.dataGridProjectScripts);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.labelCreator);
            this.Controls.Add(this.labelPojects);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonProjectRemove);
            this.Controls.Add(this.buttonProjectAdd);
            this.Controls.Add(this.listBoxProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrHome";
            this.Text = "Commander by: rdxz2";
            this.Load += new System.EventHandler(this.FrHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectScripts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectScriptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Button buttonProjectAdd;
        private System.Windows.Forms.Button buttonProjectRemove;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPojects;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.DataGridView dataGridProjectScripts;
        private System.Windows.Forms.BindingSource projectScriptBindingSource;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonProjectScriptAdd;
        private System.Windows.Forms.Button buttonProjectScriptRemove;
        private System.Windows.Forms.Label labelProjectScripts;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid;
    }
}