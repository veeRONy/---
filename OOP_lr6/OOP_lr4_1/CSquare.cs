using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    internal class CSquare : CShape, IClickable, IMovable, ISizable
    {
        private int x, y, a; // a - длина стороны квадрата
        private Pen pen;

        public CSquare(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            a = 80;
            pen = new Pen(color);
        }
         
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x - a / 2, y - a / 2, a, a);
        }

        public override CShape GetRealObject()
        {
            return this;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public void ChangeSize(int da)
        {
            a += da;
        }


        public override Rectangle GetBoundingBox()
        {
            return new Rectangle(x - a / 2, y - a / 2, a, a);
        }

        public bool isClicked(int X, int Y)
        {
            if ((X >= x - a / 2) && (X <= x + a / 2) && (Y >= y - a / 2) && (Y <= y + a / 2))
                return true;
            return false;
        }

        public bool CanMoveX(int dx, int width)
        {
            return ((x + dx - a / 2) >= 0 && (x + dx + a / 2) < width);
        }

        public bool CanMoveY(int dy, int height)
        {
            return ((y - a/2 + dy) >= 0 && (y + dy + a/2) < height);
        }

        int minSize = 5;
        public bool CanChangeSize(int da, int width, int height)
        {
            if (da < 0)
                return (a + da >= minSize);
            else
                return ((y - a/2 - da >= 0) && (y + a/2 + da < height) && (x - a/2 - da >= 0) && (x + a/2 + da < width));
        }
    }
}
