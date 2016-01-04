using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PlatiaApp
{
    class DraggingPicBox : PictureBox
    {
        public static float ResRatio;
        DraggingHelper dg;
        String ImagePath;
        Control owner;

        public DraggingPicBox(String ImagePath, Control owner)
        {
            dg = new DraggingHelper(this);
            this.ImagePath = ImagePath;
            Image AddingImage = Bitmap.FromFile(ImagePath);
            this.Image = AddingImage;
            this.owner = owner;
            owner.Controls.Add(this);
            this.Location = new Point(0, 0);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Height = Convert.ToInt32(AddingImage.Height * ResRatio);
            this.Width = Convert.ToInt32(AddingImage.Width * ResRatio);
            this.BringToFront();

           this.BackColor = Color.Transparent;
        }     
    
        public void Free()
        {
            owner.Controls.Remove(this);
            Dispose();
        }

        private void SetResolutionRatio()
        {
            float result = 1;

            float InitH = (owner as PictureBox).Image.Height;
            float InitW = (owner as PictureBox).Image.Width;
            float RectH = (owner as PictureBox).Height;
            float RectW = (owner as PictureBox).Width;

            if ((RectW / RectH) >= (InitW / InitH))
                result = RectH / InitH;//высота помещается полностью
            else
                result = RectW / InitW;

            ResRatio = result;
        }
    }
}
