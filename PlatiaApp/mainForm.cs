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

        public mainForm()
        {
            InitializeComponent();
            btOpenFolder.Click += btOpenFolder_Click;
            //btClearAll.Click += 
            btMainImage.Click += btMainImage_Click;
            BtImgDisEnable(false, btApply);
            BtImgDisEnable(false, btRemove);
            BtImgDisEnable(false, btMainImage);
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

        Image CurBgImage = null;
        private void btMainImage_Click(object sender, EventArgs e)
        {
            CurBgImage = Bitmap.FromFile(CurImgPath);
            pbMainPhoto.Image = CurBgImage;
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
            SetResolutionRatio();
            cl.AppendImage(pbMainPhoto);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            cl.RemoveImage(pbMainPhoto);
        }

        private void SetResolutionRatio()
        {
            float result = 1;

            float InitH = pbMainPhoto.Image.Height;
            float InitW = pbMainPhoto.Image.Width;
            float RectH = pbMainPhoto.Height;
            float RectW = pbMainPhoto.Width;

            if ((RectW / RectH) >= (InitW / InitH))
                result = RectH/InitH;//высота помещается полностью
            else
                result =  RectW/InitW;

            DraggingPicBox.ResRatio = result;
        }
    }
}
