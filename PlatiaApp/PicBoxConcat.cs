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
        DraggingHelper dg;
        String ImagePath;
        public DraggingPicBox(String ImagePath, Control owner)
        {
            dg = new DraggingHelper(this);
            this.ImagePath = ImagePath;
            Image AddingImage = Bitmap.FromFile(ImagePath);
            this.Image = AddingImage;
            owner.Controls.Add(this);
            this.Location = new Point(0, 0);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
        }         
    }
}
