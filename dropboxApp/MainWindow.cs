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
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {            
            info_label.Text= dbx.connect();
            files = dbx.all_Files();
                foreach (var item in files) dropbox_treeView.Nodes.Add(item);
        }
        
    }
}
