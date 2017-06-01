namespace dropboxApp
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_label = new System.Windows.Forms.Label();
            this.dropbox_treeView = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.download_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusBar);
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(19, 17);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(25, 13);
            this.info_label.TabIndex = 0;
            this.info_label.Text = "Info";
            // 
            // dropbox_treeView
            // 
            this.dropbox_treeView.Location = new System.Drawing.Point(13, 82);
            this.dropbox_treeView.Name = "dropbox_treeView";
            this.dropbox_treeView.Size = new System.Drawing.Size(259, 167);
            this.dropbox_treeView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.download_button);
            this.groupBox2.Controls.Add(this.upload_button);
            this.groupBox2.Location = new System.Drawing.Point(295, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(135, 17);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(122, 23);
            this.download_button.TabIndex = 1;
            this.download_button.Text = "Download file..";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(7, 17);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(122, 23);
            this.upload_button.TabIndex = 0;
            this.upload_button.Text = "Upload file..";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Chose root folder for saving from dropbox";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(6, 33);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(247, 23);
            this.statusBar.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dropbox_treeView);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.TreeView dropbox_treeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar statusBar;
    }
}