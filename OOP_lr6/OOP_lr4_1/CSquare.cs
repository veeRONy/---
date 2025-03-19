using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    internal class CSquare : CShape
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
    }
}
