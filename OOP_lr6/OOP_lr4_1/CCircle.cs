using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lr4_1
{
    internal class CCircle : CShape
    {
        private int x, y, r;
        private Pen pen;

        public CCircle(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            r = 40;
            pen = new Pen(color);
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x - r, y - r, 2 * r, 2 * r);
        }

        public bool isClicked(int X, int Y)
        {
            if ((X - x) * (X - x) + (Y - y) * (Y - y) <= r * r)
                return true;
            else
                return false;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public void ChangeSize(int dr)
        {
            r += dr;
        }

        public override CShape GetRealObject()
        {
            return this;
        }

        public override Rectangle GetBoundingBox()
        {
            return new Rectangle(x - r, y - r, 2 * r, 2 * r);
        }
    }
}
