using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DienstUploader {

    public partial class frmSettings : Form {

        public frmSettings() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            tbHost.Text = DienstUploader.Properties.Settings.Default.Host;
            tbUser.Text = DienstUploader.Properties.Settings.Default.Username;
            tbPassword.Text = DienstUploader.Properties.Settings.Default.Password;
            tbDirectory.Text = DienstUploader.Properties.Settings.Default.FileDirectory;
            tbExtension.Text = DienstUploader.Properties.Settings.Default.FileExtension;
            tbFTPPath.Text = DienstUploader.Properties.Settings.Default.FTPPath;
            tbFTPPathBS.Text = DienstUploader.Properties.Settings.Default.FTPPathBS;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            save();
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e) {
            save();
        }

        private Boolean validate() {
            if (Directory.Exists(tbDirectory.Text)) {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void save() {
            if (validate()) {
                DienstUploader.Properties.Settings.Default.Host = tbHost.Text;
                DienstUploader.Properties.Settings.Default.Username = tbUser.Text;
                DienstUploader.Properties.Settings.Default.Password = tbPassword.Text;
                DienstUploader.Properties.Settings.Default.FileDirectory = tbDirectory.Text;
                DienstUploader.Properties.Settings.Default.FileExtension = tbExtension.Text;
                DienstUploader.Properties.Settings.Default.FTPPath = tbFTPPath.Text;
                DienstUploader.Properties.Settings.Default.FTPPathBS = tbFTPPathBS.Text;
                DienstUploader.Properties.Settings.Default.Save();
            } else {
                MessageBox.Show("Ongeldige Directory!");
            }
        }

    }
}
