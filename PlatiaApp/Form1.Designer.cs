namespace PlatiaApp
{
    partial class Form1
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
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.mainFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tvClothesTree = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = global::PlatiaApp.Properties.Resources.PICT0038;
            this.pbMainPhoto.Location = new System.Drawing.Point(3, 3);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(513, 453);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 0;
            this.pbMainPhoto.TabStop = false;
            // 
            // btClearAll
            // 
            this.btClearAll.Location = new System.Drawing.Point(563, 17);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(84, 34);
            this.btClearAll.TabIndex = 2;
            this.btClearAll.Text = "Clear All";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.Location = new System.Drawing.Point(653, 17);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(84, 34);
            this.btOpenFolder.TabIndex = 3;
            this.btOpenFolder.Text = "Папка";
            this.btOpenFolder.UseVisualStyleBackColor = true;
            this.btOpenFolder.Click += new System.EventHandler(this.btOpenFolder_Click);
            // 
            // tvClothesTree
            // 
            this.tvClothesTree.Location = new System.Drawing.Point(563, 75);
            this.tvClothesTree.Name = "tvClothesTree";
            this.tvClothesTree.Size = new System.Drawing.Size(208, 372);
            this.tvClothesTree.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.tvClothesTree);
            this.Controls.Add(this.btOpenFolder);
            this.Controls.Add(this.btClearAll);
            this.Controls.Add(this.pbMainPhoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog mainFolderDlg;
        private System.Windows.Forms.TreeView tvClothesTree;
    }
}

