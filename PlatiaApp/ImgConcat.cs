using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlatiaApp
{
    class ImgConcat
    {
        Image CurImg;
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
            Image AddingImage = Bitmap.FromFile(AddingImgPath);
            Graphics gr = Graphics.FromImage(CurImg);
            using (gr)
            {
                gr.DrawImage(AddingImage, 0, 0);
            }
        }

        internal void Remove(string CurImgPath)
        {
            
        }
    }
}
