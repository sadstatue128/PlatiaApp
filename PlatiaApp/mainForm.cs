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
    public partial class mainForm : Form
    {
        ClothesList cl = new ClothesList();
        String CurImgPath = String.Empty;
        ImgConcat imgC = new ImgConcat();

        public mainForm()
        {
            InitializeComponent();
            btOpenFolder.Click += btOpenFolder_Click;
            btApply.Click += btApply_Click;
            btRemove.Click += btRemove_Click;
            btClearAll.Click += btClearAll_Click;
            btMainImage.Click += btMainImage_Click;
            BtImgDisEnable(false, btApply);
            BtImgDisEnable(false, btRemove);
            BtImgDisEnable(false, btMainImage);
            imgC.ImgChanged += new EventHandler(ImgChanged);
            SetMoveBtns();

        }

        private void SetMoveBtns()
        {
            btUp.Tag = Direction.up;
            btDown.Tag = Direction.down;
            btLeft.Tag = Direction.left;
            btRight.Tag = Direction.right;

            btUp.Click += btnMoveImg_Click;
            btDown.Click += btnMoveImg_Click;
            btLeft.Click += btnMoveImg_Click;
            btRight.Click += btnMoveImg_Click;
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
            imgC.MainImage = Bitmap.FromFile(CurImgPath);
            pbMainPhoto.Invalidate();
        }

        void BtImgDisEnable(Boolean En, Control ctrl)
        {
            ctrl.Enabled = En;
        }

        private void tvClothesTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cl.SetCurShmot(e.Node.Tag);
            CurImgPath = cl.GetImagePath(e.Node.Tag);
            if (String.Compare(Path.GetExtension(e.Node.Text), ".png", true) == 0)
            {
                BtImgDisEnable(true, btApply);
                BtImgDisEnable(true, btRemove);
            }
            else
            {
                BtImgDisEnable(false, btApply);
                BtImgDisEnable(false, btRemove);
            }

            if (String.Compare(Path.GetExtension(e.Node.Text),".jpg", true) == 0)
                BtImgDisEnable(true, btMainImage);
            else
                BtImgDisEnable(false, btMainImage); 
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if (CurImgPath != String.Empty)
                imgC.Add(CurImgPath);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            imgC.Remove(CurImgPath);
        }

        private void btnMoveImg_Click(object sender, EventArgs e)
        {
            Direction dir = (Direction)Enum.Parse(typeof(Direction), (sender as Button).Tag.ToString());
            imgC.Move(dir);
        }
       
        private void btClearAll_Click(object sender, EventArgs e)
        {
            imgC.ClearAll();
        }
    }
}
