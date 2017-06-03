﻿namespace dropboxApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.info_label = new System.Windows.Forms.Label();
            this.dropbox_treeView = new System.Windows.Forms.TreeView();
            this.files_groupBox = new System.Windows.Forms.GroupBox();
            this.download_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.files_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.statusBar);
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(68, 50);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(179, 23);
            this.statusBar.TabIndex = 2;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(68, 19);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(25, 13);
            this.info_label.TabIndex = 0;
            this.info_label.Text = "Info";
            // 
            // dropbox_treeView
            // 
            this.dropbox_treeView.Location = new System.Drawing.Point(6, 110);
            this.dropbox_treeView.Name = "dropbox_treeView";
            this.dropbox_treeView.Size = new System.Drawing.Size(235, 402);
            this.dropbox_treeView.TabIndex = 1;
            // 
            // files_groupBox
            // 
            this.files_groupBox.Controls.Add(this.pictureBox4);
            this.files_groupBox.Controls.Add(this.pictureBox3);
            this.files_groupBox.Controls.Add(this.pictureBox2);
            this.files_groupBox.Controls.Add(this.dropbox_treeView);
            this.files_groupBox.Controls.Add(this.download_button);
            this.files_groupBox.Controls.Add(this.upload_button);
            this.files_groupBox.Location = new System.Drawing.Point(19, 98);
            this.files_groupBox.Name = "files_groupBox";
            this.files_groupBox.Size = new System.Drawing.Size(263, 518);
            this.files_groupBox.TabIndex = 2;
            this.files_groupBox.TabStop = false;
            this.files_groupBox.Text = "Files";
            this.files_groupBox.Visible = false;
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(117, 81);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(124, 23);
            this.download_button.TabIndex = 1;
            this.download_button.Text = "Download file..";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(6, 81);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(105, 23);
            this.upload_button.TabIndex = 0;
            this.upload_button.Text = "Upload file..";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.Upload_button_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Chose root folder for saving from dropbox";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(82, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 628);
            this.Controls.Add(this.files_groupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.files_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.TreeView dropbox_treeView;
        private System.Windows.Forms.GroupBox files_groupBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}