namespace DienstUploader {
    partial class frmSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblFTPPath = new System.Windows.Forms.Label();
            this.tbFTPPath = new System.Windows.Forms.TextBox();
            this.lblFTPPathBS = new System.Windows.Forms.Label();
            this.tbFTPPathBS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP IP Adres:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(154, 35);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(192, 20);
            this.tbHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gebruiker:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(154, 63);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(192, 20);
            this.tbUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(154, 91);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Map:";
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(154, 118);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(192, 20);
            this.tbDirectory.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Extensie:";
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(154, 144);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(192, 20);
            this.tbExtension.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(42, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(118, 232);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(70, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Toepassen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblFTPPath
            // 
            this.lblFTPPath.AutoSize = true;
            this.lblFTPPath.Location = new System.Drawing.Point(10, 174);
            this.lblFTPPath.Name = "lblFTPPath";
            this.lblFTPPath.Size = new System.Drawing.Size(110, 13);
            this.lblFTPPath.TabIndex = 13;
            this.lblFTPPath.Text = "FTP Pad (Standaard):";
            // 
            // tbFTPPath
            // 
            this.tbFTPPath.Location = new System.Drawing.Point(154, 169);
            this.tbFTPPath.Name = "tbFTPPath";
            this.tbFTPPath.Size = new System.Drawing.Size(192, 20);
            this.tbFTPPath.TabIndex = 14;
            // 
            // lblFTPPathBS
            // 
            this.lblFTPPathBS.AutoSize = true;
            this.lblFTPPathBS.Location = new System.Drawing.Point(10, 197);
            this.lblFTPPathBS.Name = "lblFTPPathBS";
            this.lblFTPPathBS.Size = new System.Drawing.Size(114, 13);
            this.lblFTPPathBS.TabIndex = 15;
            this.lblFTPPathBS.Text = "FTP Pad (Bijbelstudie):";
            // 
            // tbFTPPathBS
            // 
            this.tbFTPPathBS.Location = new System.Drawing.Point(154, 194);
            this.tbFTPPathBS.Name = "tbFTPPathBS";
            this.tbFTPPathBS.Size = new System.Drawing.Size(192, 20);
            this.tbFTPPathBS.TabIndex = 16;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 267);
            this.Controls.Add(this.tbFTPPathBS);
            this.Controls.Add(this.lblFTPPathBS);
            this.Controls.Add(this.tbFTPPath);
            this.Controls.Add(this.lblFTPPath);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblFTPPath;
        private System.Windows.Forms.TextBox tbFTPPath;
        private System.Windows.Forms.Label lblFTPPathBS;
        private System.Windows.Forms.TextBox tbFTPPathBS;
    }
}