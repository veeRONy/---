using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lr4_1
{
    internal class CDecorator : CShape
    {
        private CShape shape;
        private Pen pen;
        private int x, y, a;
        public CDecorator(CShape shape)
        {
            pen = new Pen(Color.Black);
            pen.DashStyle = DashStyle.Dash;
            this.shape = shape;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x - a / 2 - 10, y - a / 2 - 10, a + 20, a + 20);
            shape.Draw(g);
        }

        public override CShape GetRealObject()
        {
            return shape.GetRealObject();
        }
    }
}
