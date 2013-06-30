namespace DienstUploader
{
    partial class frmUploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUploader));
            this.btnUpload = new System.Windows.Forms.Button();
            this.rbSoortOchtend = new System.Windows.Forms.RadioButton();
            this.gbSoortDienst = new System.Windows.Forms.GroupBox();
            this.rbSoortBijbelStudie = new System.Windows.Forms.RadioButton();
            this.rbSoortBijzonder = new System.Windows.Forms.RadioButton();
            this.rbSoortAvond = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBestand = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbxVerwijder = new System.Windows.Forms.CheckBox();
            this.llblOptions = new System.Windows.Forms.LinkLabel();
            this.llblFolder = new System.Windows.Forms.LinkLabel();
            this.btnKiesBestand = new System.Windows.Forms.Button();
            this.gbSoortDienst.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(143, 293);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rbSoortOchtend
            // 
            this.rbSoortOchtend.AutoSize = true;
            this.rbSoortOchtend.Location = new System.Drawing.Point(6, 14);
            this.rbSoortOchtend.Name = "rbSoortOchtend";
            this.rbSoortOchtend.Size = new System.Drawing.Size(94, 17);
            this.rbSoortOchtend.TabIndex = 1;
            this.rbSoortOchtend.TabStop = true;
            this.rbSoortOchtend.Text = "Ochtenddienst";
            this.rbSoortOchtend.UseVisualStyleBackColor = true;
            // 
            // gbSoortDienst
            // 
            this.gbSoortDienst.Controls.Add(this.rbSoortBijbelStudie);
            this.gbSoortDienst.Controls.Add(this.rbSoortBijzonder);
            this.gbSoortDienst.Controls.Add(this.rbSoortAvond);
            this.gbSoortDienst.Controls.Add(this.rbSoortOchtend);
            this.gbSoortDienst.Location = new System.Drawing.Point(42, 112);
            this.gbSoortDienst.Name = "gbSoortDienst";
            this.gbSoortDienst.Size = new System.Drawing.Size(227, 107);
            this.gbSoortDienst.TabIndex = 2;
            this.gbSoortDienst.TabStop = false;
            // 
            // rbSoortBijbelStudie
            // 
            this.rbSoortBijbelStudie.AutoSize = true;
            this.rbSoortBijbelStudie.Location = new System.Drawing.Point(6, 82);
            this.rbSoortBijbelStudie.Name = "rbSoortBijbelStudie";
            this.rbSoortBijbelStudie.Size = new System.Drawing.Size(83, 17);
            this.rbSoortBijbelStudie.TabIndex = 4;
            this.rbSoortBijbelStudie.TabStop = true;
            this.rbSoortBijbelStudie.Text = "Bijbel Studie";
            this.rbSoortBijbelStudie.UseVisualStyleBackColor = true;
            // 
            // rbSoortBijzonder
            // 
            this.rbSoortBijzonder.AutoSize = true;
            this.rbSoortBijzonder.Location = new System.Drawing.Point(6, 59);
            this.rbSoortBijzonder.Name = "rbSoortBijzonder";
            this.rbSoortBijzonder.Size = new System.Drawing.Size(107, 17);
            this.rbSoortBijzonder.TabIndex = 3;
            this.rbSoortBijzonder.TabStop = true;
            this.rbSoortBijzonder.Text = "Bijzondere Dienst";
            this.rbSoortBijzonder.UseVisualStyleBackColor = true;
            // 
            // rbSoortAvond
            // 
            this.rbSoortAvond.AutoSize = true;
            this.rbSoortAvond.Location = new System.Drawing.Point(6, 38);
            this.rbSoortAvond.Name = "rbSoortAvond";
            this.rbSoortAvond.Size = new System.Drawing.Size(84, 17);
            this.rbSoortAvond.TabIndex = 2;
            this.rbSoortAvond.TabStop = true;
            this.rbSoortAvond.Text = "Avonddienst";
            this.rbSoortAvond.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kies de soort dienst:";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFound.Location = new System.Drawing.Point(90, 29);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(112, 15);
            this.lblFound.TabIndex = 4;
            this.lblFound.Text = "Label aan het zoeken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // lblBestand
            // 
            this.lblBestand.AutoSize = true;
            this.lblBestand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBestand.Location = new System.Drawing.Point(90, 54);
            this.lblBestand.Name = "lblBestand";
            this.lblBestand.Size = new System.Drawing.Size(76, 15);
            this.lblBestand.TabIndex = 6;
            this.lblBestand.Text = "Geen bestand";
            this.lblBestand.Click += new System.EventHandler(this.lblBestand_Click);
            this.lblBestand.MouseLeave += new System.EventHandler(this.lblBestand_MouseLeave);
            this.lblBestand.MouseHover += new System.EventHandler(this.lblBestand_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bestand:";
            // 
            // ckbxVerwijder
            // 
            this.ckbxVerwijder.AutoSize = true;
            this.ckbxVerwijder.Location = new System.Drawing.Point(42, 250);
            this.ckbxVerwijder.Name = "ckbxVerwijder";
            this.ckbxVerwijder.Size = new System.Drawing.Size(160, 17);
            this.ckbxVerwijder.TabIndex = 8;
            this.ckbxVerwijder.Text = "Verwijder bestand na upload";
            this.ckbxVerwijder.UseVisualStyleBackColor = true;
            this.ckbxVerwijder.Visible = false;
            // 
            // llblOptions
            // 
            this.llblOptions.AutoSize = true;
            this.llblOptions.LinkColor = System.Drawing.Color.Black;
            this.llblOptions.Location = new System.Drawing.Point(233, 306);
            this.llblOptions.Name = "llblOptions";
            this.llblOptions.Size = new System.Drawing.Size(60, 13);
            this.llblOptions.TabIndex = 9;
            this.llblOptions.TabStop = true;
            this.llblOptions.Text = "Instellingen";
            this.llblOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llblFolder
            // 
            this.llblFolder.AutoSize = true;
            this.llblFolder.LinkColor = System.Drawing.Color.Black;
            this.llblFolder.Location = new System.Drawing.Point(233, 289);
            this.llblFolder.Name = "llblFolder";
            this.llblFolder.Size = new System.Drawing.Size(36, 13);
            this.llblFolder.TabIndex = 10;
            this.llblFolder.TabStop = true;
            this.llblFolder.Text = "Folder";
            this.llblFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFolder_LinkClicked);
            // 
            // btnKiesBestand
            // 
            this.btnKiesBestand.Location = new System.Drawing.Point(36, 293);
            this.btnKiesBestand.Name = "btnKiesBestand";
            this.btnKiesBestand.Size = new System.Drawing.Size(94, 23);
            this.btnKiesBestand.TabIndex = 11;
            this.btnKiesBestand.Text = "Kies Bestand";
            this.btnKiesBestand.UseVisualStyleBackColor = true;
            this.btnKiesBestand.Click += new System.EventHandler(this.btnKiesBestand_Click);
            // 
            // frmUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 328);
            this.Controls.Add(this.btnKiesBestand);
            this.Controls.Add(this.llblFolder);
            this.Controls.Add(this.llblOptions);
            this.Controls.Add(this.ckbxVerwijder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBestand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSoortDienst);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUploader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dienst Uploader";
            this.Load += new System.EventHandler(this.frmDienstUploader_Load);
            this.gbSoortDienst.ResumeLayout(false);
            this.gbSoortDienst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RadioButton rbSoortOchtend;
        private System.Windows.Forms.GroupBox gbSoortDienst;
        private System.Windows.Forms.RadioButton rbSoortBijzonder;
        private System.Windows.Forms.RadioButton rbSoortAvond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBestand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbxVerwijder;
        private System.Windows.Forms.LinkLabel llblOptions;
        private System.Windows.Forms.LinkLabel llblFolder;
        private System.Windows.Forms.Button btnKiesBestand;
        private System.Windows.Forms.RadioButton rbSoortBijbelStudie;
    }
}

