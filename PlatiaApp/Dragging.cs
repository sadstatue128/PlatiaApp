using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace PlatiaApp
{
    class DraggingHelper
    {
        public DraggingHelper(PictureBox LpicBox)
        {
            picBox = LpicBox;
            picBox.MouseDown += picBox_MouseDown;
            picBox.MouseMove += picBox_MouseMove;
            picBox.MouseUp += picBox_MouseUp;
        }

        PictureBox picBox;
        int iOldX, iOldY, iClickX, iClickY;
        Boolean clicked;
        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = ConvertFromChildToForm(e.X, e.Y, picBox);
                iOldX = p.X;
                iOldY = p.Y;
                iClickX = e.X;
                iClickY = e.Y;
                clicked = true;
            }
        }

        private Point ConvertFromChildToForm(int x, int y, Control control)
        {
            Point p = new Point(x, y);
            control.Location = p;
            return p;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                Point p = new Point(); // New Coordinate
                p.X = e.X + picBox.Left;
                p.Y = e.Y + picBox.Top;
                picBox.Left = p.X - iClickX;
                picBox.Top = p.Y - iClickY;
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        
    }
}
