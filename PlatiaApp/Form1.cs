using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlatiaApp
{
    public partial class Form1 : Form
    {
        ClothesList cl = new ClothesList();
        ImgConcat imgC = new ImgConcat();

        public Form1()
        {
            InitializeComponent();
            imgC.ImgChanged += new EventHandler(ImgChanged);
        }

        public void ImgChanged(object sender, EventArgs e)
        {
            pbMainPhoto.Image = imgC.MainImage;
            pbMainPhoto.Invalidate();
            btOpenFolder.Click += btOpenFolder_Click;
            //btClearAll.Click += 
            btMainImage.Click += btMainImage_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(pbMainPhoto.Image);
            using (gr)
            {
                gr.DrawImage(Properties.Resources.green, 0, 0);
            }
            pbMainPhoto.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(pbMainPhoto.Image);
            using (gr)
            {
                gr.DrawImage(Properties.Resources.PICT0038, 0, 0);
            }
            pbMainPhoto.Invalidate();
        }

        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            if (mainFolderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cl.ReadFromFolder(mainFolderDlg.SelectedPath);
                cl.FillTreeNodes(tvClothesTree.Nodes);
            }
        }

        private void btMainImage_Click(object sender, EventArgs e)
        {
            if (openBG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgC.MainImage = Bitmap.FromFile(openBG.FileName);
            }
        }
    }
}
