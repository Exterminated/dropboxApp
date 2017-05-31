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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.info_label);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 36);
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
            this.dropbox_treeView.Location = new System.Drawing.Point(13, 56);
            this.dropbox_treeView.Name = "dropbox_treeView";
            this.dropbox_treeView.Size = new System.Drawing.Size(259, 193);
            this.dropbox_treeView.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dropbox_treeView);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.TreeView dropbox_treeView;
    }
}