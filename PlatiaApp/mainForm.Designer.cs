﻿namespace PlatiaApp
{
    partial class mainForm
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
            this.mainFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.pnImg = new System.Windows.Forms.Panel();
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.pnManage = new System.Windows.Forms.Panel();
            this.LayoutBtns = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.tvClothesTree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMainImage = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            this.Layout.SuspendLayout();
            this.pnManage.SuspendLayout();
            this.LayoutBtns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnImg
            // 
            this.pnImg.Controls.Add(this.pbMainPhoto);
            this.pnImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImg.Location = new System.Drawing.Point(3, 3);
            this.pnImg.Name = "pnImg";
            this.pnImg.Size = new System.Drawing.Size(506, 453);
            this.pnImg.TabIndex = 7;
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pbMainPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(506, 453);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 1;
            this.pbMainPhoto.TabStop = false;
            // 
            // Layout
            // 
            this.Layout.AllowDrop = true;
            this.Layout.ColumnCount = 2;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Layout.Controls.Add(this.pnManage, 1, 0);
            this.Layout.Controls.Add(this.pnImg, 0, 0);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 1;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Size = new System.Drawing.Size(801, 459);
            this.Layout.TabIndex = 9;
            // 
            // pnManage
            // 
            this.pnManage.Controls.Add(this.LayoutBtns);
            this.pnManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnManage.Location = new System.Drawing.Point(515, 3);
            this.pnManage.Name = "pnManage";
            this.pnManage.Size = new System.Drawing.Size(283, 453);
            this.pnManage.TabIndex = 9;
            // 
            // LayoutBtns
            // 
            this.LayoutBtns.ColumnCount = 1;
            this.LayoutBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutBtns.Controls.Add(this.panel1, 0, 0);
            this.LayoutBtns.Controls.Add(this.tvClothesTree, 0, 1);
            this.LayoutBtns.Controls.Add(this.panel2, 0, 2);
            this.LayoutBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutBtns.Location = new System.Drawing.Point(0, 0);
            this.LayoutBtns.Name = "LayoutBtns";
            this.LayoutBtns.RowCount = 3;
            this.LayoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55779F));
            this.LayoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.44221F));
            this.LayoutBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.LayoutBtns.Size = new System.Drawing.Size(283, 453);
            this.LayoutBtns.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClearAll);
            this.panel1.Controls.Add(this.btOpenFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 33);
            this.panel1.TabIndex = 0;
            // 
            // btClearAll
            // 
            this.btClearAll.Location = new System.Drawing.Point(43, 3);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(83, 34);
            this.btClearAll.TabIndex = 14;
            this.btClearAll.Text = "Снять все";
            this.btClearAll.UseVisualStyleBackColor = true;
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.Location = new System.Drawing.Point(164, 4);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(63, 34);
            this.btOpenFolder.TabIndex = 8;
            this.btOpenFolder.Text = "Папка";
            this.btOpenFolder.UseVisualStyleBackColor = true;
            // 
            // tvClothesTree
            // 
            this.tvClothesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvClothesTree.Location = new System.Drawing.Point(3, 42);
            this.tvClothesTree.Name = "tvClothesTree";
            this.tvClothesTree.Size = new System.Drawing.Size(277, 293);
            this.tvClothesTree.TabIndex = 9;
            this.tvClothesTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvClothesTree_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btMainImage);
            this.panel2.Controls.Add(this.btApply);
            this.panel2.Controls.Add(this.btRemove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 109);
            this.panel2.TabIndex = 10;
            // 
            // btMainImage
            // 
            this.btMainImage.Location = new System.Drawing.Point(199, 7);
            this.btMainImage.Name = "btMainImage";
            this.btMainImage.Size = new System.Drawing.Size(59, 23);
            this.btMainImage.TabIndex = 13;
            this.btMainImage.Text = "Фон";
            this.btMainImage.UseVisualStyleBackColor = true;
            this.btMainImage.Click += new System.EventHandler(this.btMainImage_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(26, 7);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(69, 23);
            this.btApply.TabIndex = 11;
            this.btApply.Text = "Надеть";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(120, 7);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(58, 23);
            this.btRemove.TabIndex = 12;
            this.btRemove.Text = "Снять";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.Layout);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.pnImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            this.Layout.ResumeLayout(false);
            this.pnManage.ResumeLayout(false);
            this.LayoutBtns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog mainFolderDlg;
        private System.Windows.Forms.Panel pnImg;
        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Panel pnManage;
        private System.Windows.Forms.TreeView tvClothesTree;
        private System.Windows.Forms.Button btOpenFolder;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.TableLayoutPanel LayoutBtns;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btMainImage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

