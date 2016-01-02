using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PlatiaApp
{
    public partial class Form1 : Form
    {
        ClothesList cl = new ClothesList();
        ImgConcat imgC = new ImgConcat();
        String CurImgPath = String.Empty;

        public Form1()
        {
            InitializeComponent();
            imgC.ImgChanged += new EventHandler(ImgChanged);
            btOpenFolder.Click += btOpenFolder_Click;
            //btClearAll.Click += 
            btMainImage.Click += btMainImage_Click;
            BtImgDisEnable(false);
        }

        public void ImgChanged(object sender, EventArgs e)
        {
            pbMainPhoto.Image = imgC.MainImage;
            pbMainPhoto.Invalidate();           
        }
        
        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            if (mainFolderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cl.ReadFromFolder(mainFolderDlg.SelectedPath);
                cl.FillTreeNodes(tvClothesTree.Nodes);
                tvClothesTree.ExpandAll();
            }
        }

        private void btMainImage_Click(object sender, EventArgs e)
        {
            if (openBG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgC.MainImage = Bitmap.FromFile(openBG.FileName);
            }
        }

        void BtImgDisEnable(Boolean En)
        {
            btApply.Enabled = En;
            btRemove.Enabled = En;
        }

        private void tvClothesTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CurImgPath = cl.GetImagePath(e.Node.Tag);
            if (Path.GetExtension(CurImgPath) == ".png")
                BtImgDisEnable(true);                
            else
                BtImgDisEnable(false);
           
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if (CurImgPath != String.Empty)
            {
                imgC.Add(CurImgPath);
            }
            pbMainPhoto.Invalidate();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox1.Image = Image.FromFile(files[0]);

            }
        }

        private void Layout_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Layout_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox1.Image = Image.FromFile(files[0]);

            }
        }

        
    }
}
