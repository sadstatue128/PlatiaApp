using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlatiaApp
{
    enum Direction
    {
        up,
        down,
        left, 
        right
    }

    class ImgConcat
    {
        Image CurImg;
        Image AppendingImage;
        Point AppImgPoint;
        Image InitialImage;
        Image PreImage;
        public EventHandler ImgChanged;

        public Image MainImage
        {
            set
            {
                CurImg = value;
                InitialImage = value;
                PreImage = value;
                OnImageChanged();
            }
            get
            { return CurImg; }
        }

        void OnImageChanged()
        {
            if (ImgChanged != null)
            {
                ImgChanged(this, null);
            }
        }

        internal void Add(string AddingImgPath)
        {
            PreImage = CurImg;
            AppendingImage = Bitmap.FromFile(AddingImgPath);
            Graphics gr = Graphics.FromImage(CurImg);
            using (gr)
            {
                gr.DrawImage(AppendingImage, 0, 0);
            }
        }

        internal void Remove(string CurImgPath)
        {
            
        }

        internal void Move(Direction direction)
        {
            CurImg = PreImage;
            Graphics gr = Graphics.FromImage(CurImg);
            if (direction == Direction.up)
            {
                Point pt = 
            }
            using (gr)
            {                
                gr.DrawImage(AppendingImage, 0, 0);
            }
            
        }
    }
}
