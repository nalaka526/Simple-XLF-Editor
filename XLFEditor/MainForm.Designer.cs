namespace XLFReader
{
    partial class MainForm
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
            this.openXLFDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetailsSave = new System.Windows.Forms.Button();
            this.lblDetailsRowId = new System.Windows.Forms.Label();
            this.txtDetaillsTarget = new System.Windows.Forms.TextBox();
            this.txtDetaillsSource = new System.Windows.Forms.TextBox();
            this.txtDetaillsId = new System.Windows.Forms.TextBox();
            this.txtDetaillsDescription = new System.Windows.Forms.TextBox();
            this.txtDetaillsMeaning = new System.Windows.Forms.TextBox();
            this.btnCloseDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.rdoFilterTranslated = new System.Windows.Forms.RadioButton();
            this.rdoFilterNotTranslated = new System.Windows.Forms.RadioButton();
            this.rdoFilterAll = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTranslations = new System.Windows.Forms.DataGridView();
            this.tbcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openXLFDialog
            // 
            this.openXLFDialog.FileName = "openFileDialog1";
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(41, 77);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(1200, 32);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(35, 1330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1504, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.btnDetailsSave);
            this.pnlDetails.Controls.Add(this.lblDetailsRowId);
            this.pnlDetails.Controls.Add(this.txtDetaillsTarget);
            this.pnlDetails.Controls.Add(this.txtDetaillsSource);
            this.pnlDetails.Controls.Add(this.txtDetaillsId);
            this.pnlDetails.Controls.Add(this.txtDetaillsDescription);
            this.pnlDetails.Controls.Add(this.txtDetaillsMeaning);
            this.pnlDetails.Controls.Add(this.btnCloseDetails);
            this.pnlDetails.Location = new System.Drawing.Point(0, 140);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(2640, 1280);
            this.pnlDetails.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Meaning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Translation Id";
            // 
            // btnDetailsSave
            // 
            this.btnDetailsSave.Location = new System.Drawing.Point(2297, 1182);
            this.btnDetailsSave.Name = "btnDetailsSave";
            this.btnDetailsSave.Size = new System.Drawing.Size(275, 57);
            this.btnDetailsSave.TabIndex = 9;
            this.btnDetailsSave.Text = "Save / Close";
            this.btnDetailsSave.UseVisualStyleBackColor = true;
            this.btnDetailsSave.Click += new System.EventHandler(this.btnDetailsSave_Click);
            // 
            // lblDetailsRowId
            // 
            this.lblDetailsRowId.AutoSize = true;
            this.lblDetailsRowId.Location = new System.Drawing.Point(2455, 122);
            this.lblDetailsRowId.Name = "lblDetailsRowId";
            this.lblDetailsRowId.Size = new System.Drawing.Size(0, 32);
            this.lblDetailsRowId.TabIndex = 8;
            this.lblDetailsRowId.Visible = false;
            // 
            // txtDetaillsTarget
            // 
            this.txtDetaillsTarget.Location = new System.Drawing.Point(41, 777);
            this.txtDetaillsTarget.Multiline = true;
            this.txtDetaillsTarget.Name = "txtDetaillsTarget";
            this.txtDetaillsTarget.Size = new System.Drawing.Size(2531, 340);
            this.txtDetaillsTarget.TabIndex = 7;
            // 
            // txtDetaillsSource
            // 
            this.txtDetaillsSource.Location = new System.Drawing.Point(41, 330);
            this.txtDetaillsSource.Multiline = true;
            this.txtDetaillsSource.Name = "txtDetaillsSource";
            this.txtDetaillsSource.ReadOnly = true;
            this.txtDetaillsSource.Size = new System.Drawing.Size(2531, 340);
            this.txtDetaillsSource.TabIndex = 6;
            // 
            // txtDetaillsId
            // 
            this.txtDetaillsId.Location = new System.Drawing.Point(374, 49);
            this.txtDetaillsId.Name = "txtDetaillsId";
            this.txtDetaillsId.ReadOnly = true;
            this.txtDetaillsId.Size = new System.Drawing.Size(660, 38);
            this.txtDetaillsId.TabIndex = 5;
            // 
            // txtDetaillsDescription
            // 
            this.txtDetaillsDescription.Location = new System.Drawing.Point(374, 117);
            this.txtDetaillsDescription.Name = "txtDetaillsDescription";
            this.txtDetaillsDescription.ReadOnly = true;
            this.txtDetaillsDescription.Size = new System.Drawing.Size(660, 38);
            this.txtDetaillsDescription.TabIndex = 4;
            // 
            // txtDetaillsMeaning
            // 
            this.txtDetaillsMeaning.Location = new System.Drawing.Point(374, 188);
            this.txtDetaillsMeaning.Name = "txtDetaillsMeaning";
            this.txtDetaillsMeaning.ReadOnly = true;
            this.txtDetaillsMeaning.Size = new System.Drawing.Size(660, 38);
            this.txtDetaillsMeaning.TabIndex = 3;
            // 
            // btnCloseDetails
            // 
            this.btnCloseDetails.Location = new System.Drawing.Point(2007, 1182);
            this.btnCloseDetails.Name = "btnCloseDetails";
            this.btnCloseDetails.Size = new System.Drawing.Size(275, 57);
            this.btnCloseDetails.TabIndex = 2;
            this.btnCloseDetails.Text = "Close";
            this.btnCloseDetails.UseVisualStyleBackColor = true;
            this.btnCloseDetails.Click += new System.EventHandler(this.btnCloseDetails_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(41, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2530, 2);
            this.label7.TabIndex = 16;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.rdoFilterTranslated);
            this.pnlList.Controls.Add(this.rdoFilterNotTranslated);
            this.pnlList.Controls.Add(this.rdoFilterAll);
            this.pnlList.Controls.Add(this.btnSave);
            this.pnlList.Controls.Add(this.dgvTranslations);
            this.pnlList.Controls.Add(this.btnReload);
            this.pnlList.Location = new System.Drawing.Point(0, 140);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(2640, 1280);
            this.pnlList.TabIndex = 19;
            // 
            // rdoFilterTranslated
            // 
            this.rdoFilterTranslated.AutoSize = true;
            this.rdoFilterTranslated.Location = new System.Drawing.Point(2356, 40);
            this.rdoFilterTranslated.Name = "rdoFilterTranslated";
            this.rdoFilterTranslated.Size = new System.Drawing.Size(187, 36);
            this.rdoFilterTranslated.TabIndex = 22;
            this.rdoFilterTranslated.TabStop = true;
            this.rdoFilterTranslated.Text = "Translated";
            this.rdoFilterTranslated.UseVisualStyleBackColor = true;
            this.rdoFilterTranslated.CheckedChanged += new System.EventHandler(this.rdoFilterTranslated_CheckedChanged);
            // 
            // rdoFilterNotTranslated
            // 
            this.rdoFilterNotTranslated.AutoSize = true;
            this.rdoFilterNotTranslated.Location = new System.Drawing.Point(2089, 40);
            this.rdoFilterNotTranslated.Name = "rdoFilterNotTranslated";
            this.rdoFilterNotTranslated.Size = new System.Drawing.Size(238, 36);
            this.rdoFilterNotTranslated.TabIndex = 21;
            this.rdoFilterNotTranslated.TabStop = true;
            this.rdoFilterNotTranslated.Text = "Not Translated";
            this.rdoFilterNotTranslated.UseVisualStyleBackColor = true;
            this.rdoFilterNotTranslated.CheckedChanged += new System.EventHandler(this.rdoFilterNotTranslated_CheckedChanged);
            // 
            // rdoFilterAll
            // 
            this.rdoFilterAll.AutoSize = true;
            this.rdoFilterAll.Checked = true;
            this.rdoFilterAll.Location = new System.Drawing.Point(1966, 40);
            this.rdoFilterAll.Name = "rdoFilterAll";
            this.rdoFilterAll.Size = new System.Drawing.Size(85, 36);
            this.rdoFilterAll.TabIndex = 20;
            this.rdoFilterAll.TabStop = true;
            this.rdoFilterAll.Text = "All";
            this.rdoFilterAll.UseVisualStyleBackColor = true;
            this.rdoFilterAll.CheckedChanged += new System.EventHandler(this.rdoFilterAll_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2297, 1182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(275, 57);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save All";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTranslations
            // 
            this.dgvTranslations.AllowUserToAddRows = false;
            this.dgvTranslations.AllowUserToDeleteRows = false;
            this.dgvTranslations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranslations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcId,
            this.tbcSource,
            this.tbcTarget,
            this.tbcSave});
            this.dgvTranslations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTranslations.Location = new System.Drawing.Point(41, 106);
            this.dgvTranslations.Name = "dgvTranslations";
            this.dgvTranslations.RowTemplate.Height = 40;
            this.dgvTranslations.Size = new System.Drawing.Size(2531, 1060);
            this.dgvTranslations.TabIndex = 8;
            this.dgvTranslations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTranslations_CellClick);
            this.dgvTranslations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTranslations_CellDoubleClick);
            // 
            // tbcId
            // 
            this.tbcId.DataPropertyName = "Id";
            this.tbcId.HeaderText = "Id";
            this.tbcId.Name = "tbcId";
            this.tbcId.ReadOnly = true;
            this.tbcId.Visible = false;
            // 
            // tbcSource
            // 
            this.tbcSource.DataPropertyName = "Source";
            this.tbcSource.HeaderText = "Source";
            this.tbcSource.Name = "tbcSource";
            this.tbcSource.ReadOnly = true;
            this.tbcSource.ToolTipText = "Double click to open details";
            this.tbcSource.Width = 420;
            // 
            // tbcTarget
            // 
            this.tbcTarget.DataPropertyName = "Target";
            this.tbcTarget.HeaderText = "Target";
            this.tbcTarget.Name = "tbcTarget";
            this.tbcTarget.Width = 420;
            // 
            // tbcSave
            // 
            this.tbcSave.DataPropertyName = "Id";
            this.tbcSave.HeaderText = "Save";
            this.tbcSave.Name = "tbcSave";
            this.tbcSave.Text = "Save";
            this.tbcSave.UseColumnTextForButtonValue = true;
            this.tbcSave.Width = 47;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(39, 30);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(184, 57);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(2792, 49);
            this.MainMenuStrip.TabIndex = 20;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 48);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(1372, 77);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(1200, 32);
            this.lblFilePath.TabIndex = 21;
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2792, 1457);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simple XLIFF (1.2) Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslations)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openXLFDialog;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button btnCloseDetails;
        private System.Windows.Forms.TextBox txtDetaillsTarget;
        private System.Windows.Forms.TextBox txtDetaillsSource;
        private System.Windows.Forms.TextBox txtDetaillsId;
        private System.Windows.Forms.TextBox txtDetaillsDescription;
        private System.Windows.Forms.TextBox txtDetaillsMeaning;
        private System.Windows.Forms.Label lblDetailsRowId;
        private System.Windows.Forms.Button btnDetailsSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTranslations;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton rdoFilterTranslated;
        private System.Windows.Forms.RadioButton rdoFilterNotTranslated;
        private System.Windows.Forms.RadioButton rdoFilterAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTarget;
        private System.Windows.Forms.DataGridViewButtonColumn tbcSave;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label lblFilePath;
    }
}

