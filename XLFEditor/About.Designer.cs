namespace XlfEditor
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(43, 44);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(266, 32);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "labelProductName";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(43, 102);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(174, 32);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "labelVersion";
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(23, 170);
            this.txtLicence.Multiline = true;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicence.Size = new System.Drawing.Size(1007, 386);
            this.txtLicence.TabIndex = 2;
            this.txtLicence.Text = resources.GetString("txtLicence.Text");
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(824, 592);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(206, 57);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 677);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(24, 21, 24, 21);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Button btnOk;
    }
}
