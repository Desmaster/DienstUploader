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

namespace DienstUploader {

    public partial class frmUploader : Form {

        FTP ftp = null;
        frmSettings settings;

        string host, user, password, directory, extension, ftpDefault, ftpBS;
        string currentFile;

        public frmUploader() {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e) {
            if (!(rbSoortOchtend.Checked == false && rbSoortAvond.Checked == false && rbSoortBijzonder.Checked == false && rbSoortBijbelStudie.Checked == false)) {
                if (currentFile != "") {
                    if (ckbxVerwijder.Checked) {

                        if (MessageBox.Show("Weet u zeker dat u het bestand wilt verwijderen na het uploaden?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.No) {
                            return;
                        }
                    }

                    ftp = new FTP(host, user, password);

                    string datum = DateTime.Now.ToString("dd/MM/yyyy");
                    string soort = getSoort();
                    string filename = soort + datum;
                    string oldFile = currentFile;
                    string uploadedDir = directory + "uploaded";
                    string uploadedDirFile = directory + @"uploaded\";

                    filename = filename.Replace("-", "");

                    if (!Directory.Exists(uploadedDir)) {
                        Directory.CreateDirectory(uploadedDir);
                    }

                    File.Move(currentFile, uploadedDirFile + filename + "." + extension);

                    currentFile = uploadedDirFile + filename + "." + extension;

                    ftp.upload("Test/" + filename + "." + extension, currentFile);

                    //if (ckbxVerwijder.Checked) {
                    //    File.Delete(currentFile);
                    //}

                    ftp = null;

                    init();
                }
            } else {
                MessageBox.Show("Geen dienstsoort gekozen!");
            }
        }

        private string getSoort() {
            if (rbSoortOchtend.Checked) {
                return "mo";
            } else if (rbSoortAvond.Checked) {
                return "av";
            } else if (rbSoortBijzonder.Checked) {
                return "bd";
            } else if (rbSoortBijbelStudie.Checked) {
                return "bs";
            }
            return "";
        }

        private void frmDienstUploader_Load(object sender, EventArgs e) {
            init();
        }

        private void init() {
            host = DienstUploader.Properties.Settings.Default.Host;
            user = DienstUploader.Properties.Settings.Default.Username;
            password = DienstUploader.Properties.Settings.Default.Password;
            directory = DienstUploader.Properties.Settings.Default.FileDirectory;
            extension = DienstUploader.Properties.Settings.Default.FileExtension;
            ftpDefault = DienstUploader.Properties.Settings.Default.FTPPath;
            ftpBS = DienstUploader.Properties.Settings.Default.FTPPathBS;
            initFile();
            if (currentFile == "") {
                btnUpload.Enabled = false;
            } else {
                btnUpload.Enabled = true;
            }
        }

        private void initFile() {
            if (getCurrentFile()) {
                lblFound.Text = "Opnamebestand gevonden!";
                lblFound.ForeColor = Color.Green;
                lblBestand.Text = currentFile;
            } else {
                lblFound.Text = "Geen opnamebestand gevonden!";
                lblFound.ForeColor = Color.Red;
                lblBestand.Text = "Geen bestand";
            }
        }

        private bool getCurrentFile() {
            try {
                string[] files = Directory.GetFiles(directory, "*." + extension);
                currentFile = files[0];
                Console.WriteLine(currentFile);
                return true;
            } catch {
                currentFile = "";
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            settings = new frmSettings();
            settings.Activate();
            settings.Visible = true;
            settings.FormClosed += settings_FormClosed;
        }

        void settings_FormClosed(object sender, FormClosedEventArgs e) {
            init();
            Console.WriteLine("Settings form closed!");
        }

        private void llblFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(directory);
        }

        private void btnKiesBestand_Click(object sender, EventArgs e) {
            OpenFileDialog browser = new OpenFileDialog();
            browser.InitialDirectory = directory;
            browser.Multiselect = false;
            browser.ShowDialog();

            string[] filenameArray = browser.FileName.Split('.');
            if (filenameArray[filenameArray.Length - 1] == extension) {
                currentFile = browser.FileName;
                lblFound.Text = "Opnamebestand gekozen!";
                lblFound.ForeColor = Color.Green;
                lblBestand.Text = currentFile;
            }


        }

    }
}
