using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                statusBar.Value = 15;
                info_label.Text = dbx.Connect();
                statusBar.Value = 50;
                files = dbx.All_Files();
                statusBar.Value = 75;
                foreach (var item in files) dropbox_treeView.Nodes.Add(item);
                statusBar.Value = 95;
                ChooseFolder();
                statusBar.Value = 100;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
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
            statusBar.Value = 0;
            //from dropbox
            dbx.Download(@"/dropboxAPP","text.txt");
            statusBar.Value = 100;
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            statusBar.Value = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbx.Upload(@"/dropboxAPP",  openFileDialog.FileName.ToString(), openFileDialog.FileName.ToString());
                //dbx.Upload(@"/dropboxAPP/", "text.txt", "Inside text");
            }
            statusBar.Value = 100;
        }
    }
}
