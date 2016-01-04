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
        
        public EventHandler ImgChanged;

        public Image MainImage
        {
            set
            {
                CurImg = value.Clone() as Image;
                PreImage = value.Clone() as Image;
                InitialImage = value.Clone() as Image; 
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

        Image CurImg; //текущее изобр с которым работаем
        Image AppendingImage; //добавляемое изображение
        Image PreImage; //изображение до добавления AppendingImage
        Image InitialImage; //фон
        Point AppImgPoint;
        

        internal void Add(string AddingImgPath)
        {
            PreImage = CurImg.Clone() as Image;
            AppendingImage = Bitmap.FromFile(AddingImgPath);
            AppImgPoint = new Point(0, 0);
            DrawAppendingImage();
        }

        internal void Remove(string CurImgPath)
        {
            CurImg = PreImage.Clone() as Image;
            OnImageChanged();
        }

        internal void Move(Direction direction)
        {
            CurImg = PreImage.Clone() as Image;
            switch (direction)
            {
                case Direction.up:
                    AppImgPoint.Y = AppImgPoint.Y - 10;
                    break;

                case Direction.down:
                    AppImgPoint.Y = AppImgPoint.Y + 10;
                    break;

                case Direction.left:
                    AppImgPoint.X = AppImgPoint.X - 10;
                    break;

                case Direction.right:
                    AppImgPoint.X = AppImgPoint.X + 10;
                    break;                                     
            }
            DrawAppendingImage();            
        }

        private void DrawAppendingImage()
        {
            Graphics gr = Graphics.FromImage(CurImg);
            using (gr)
            {
                gr.DrawImage(AppendingImage, AppImgPoint);
            }
            OnImageChanged();
        }

        internal void ClearAll()
        {
            CurImg = InitialImage.Clone() as Image;
            OnImageChanged();
        }
    }
}
