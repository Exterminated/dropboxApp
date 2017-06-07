using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace dropboxApp
{
    public partial class MainWindow : Form
    {
        private Dropbox dbx = new Dropbox();
        private List<string> files = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            statusBar.Value = 0;
            statusBar.Maximum = 100;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadInfo();
            }
            catch (Exception ex) {
                DialogResult result = MessageBox.Show("Can't connect with Dropbox servers.\nPlease check your Internet connection","Connection Trouble",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.Retry) {
                    LoadInfo();                   
                }
            }
            
        }
        private void LoadInfo() {
            statusBar.Value = 15;
            info_label.Text = dbx.Connect();
            statusBar.Value = 50;
            files = dbx.All_Files();
            statusBar.Value = 75;
            SetImages();
            //foreach (var item in files) dropbox_treeView.Nodes.Add(item);
            //statusBar.Value = 95;
            //ChooseFolder();
            files_groupBox.Visible = true;
            statusBar.Value = 100;
        }
        private void SetImages() {
            var lst = new ImageList();

            lst.Images.Add(Image.FromFile(@"C:\Users\devja\documents\visual studio 2017\Projects\dropboxApp\dropboxApp\icons\folder-5.png"));
            lst.Images.Add(Image.FromFile(@"C:\Users\devja\documents\visual studio 2017\Projects\dropboxApp\dropboxApp\icons\file.png"));

            dropbox_treeView.ImageList = lst;

            foreach (var item in files) {
                if(!item.Contains(".")) dropbox_treeView.Nodes.Add(new TreeNode { ImageIndex = 0, Text = item.ToString() });
                else dropbox_treeView.Nodes.Add(new TreeNode { ImageIndex = 1, Text = item.ToString() });
            }
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dbx.PATH = folderBrowserDialog.SelectedPath;
            }            
        }

        private void Download_button_Click(object sender, EventArgs e)
        {
            statusBar.Value = 5;
            //from dropbox
            Stream file_cloud;
            file_cloud = dbx.Download("dropboxAPP","text.txt");

            try
            {
                statusBar.Value = 50;
                ChooseFolder();

                statusBar.Value = 75;

                FileStream fileStream = File.Create(folderBrowserDialog.SelectedPath.ToString() + @"\" + "text.txt");
                file_cloud.CopyTo(fileStream);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read file from dropbox", "File Trouble", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }      
            statusBar.Value = 100;
        }

        private void Upload_button_Click(object sender, EventArgs e)
        {
            statusBar.Value = 0;
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //dbx.Upload(dropbox_treeView.SelectedNode.Text, openFileDialog.FileName.ToString());
                dbx.Upload("dropboxAPP", openFileDialog.FileName.ToString());
            }
            statusBar.Value = 100;
        }
        
    }
}
