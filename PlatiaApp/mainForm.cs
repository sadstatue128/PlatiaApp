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
        ImgConcat imgC = new ImgConcat();
        String CurImgPath = String.Empty;

        public mainForm()
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
            cl.SetCurShmot(e.Node.Tag);
            CurImgPath = cl.GetImagePath(e.Node.Tag);
            if (Path.GetExtension(e.Node.Text) == ".png")
                BtImgDisEnable(true);                
            else
                BtImgDisEnable(false);          
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            /*if (CurImgPath != String.Empty)
              imgC.Add(CurImgPath);
            pbMainPhoto.Invalidate();*/
            cl.AppendImage(pbMainPhoto);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {

        }


        
        
    }
}
