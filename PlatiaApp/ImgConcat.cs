using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PlatiaApp
{
    class ImgConcat
    {
        Image MainImg;
        Image SourceImg;
        public EventHandler ImgChanged;

        public Image MainImage
        {
            set
            {
                MainImg = value;
                SourceImg = value;
                OnImageChanged();
            }
            get
            { return MainImg; }
        }

        void OnImageChanged()
        {
            if (ImgChanged != null)
            {
                ImgChanged(this, null);
            }
        }


    }
}
