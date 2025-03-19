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
        public CDecorator(CShape shape)
        {
            pen = new Pen(Color.Black);
            pen.DashStyle = DashStyle.Dash;
            this.shape = shape;
        }
        public override void Draw(Graphics g)
        {
            Rectangle boundingBox = shape.GetRealObject().GetBoundingBox();
            g.DrawRectangle(pen, boundingBox.X - 10, boundingBox.Y - 10, boundingBox.Width + 20, boundingBox.Height + 20);
            shape.Draw(g);
        }

        public override CShape GetRealObject()
        {
            return shape.GetRealObject();
        }

        public override Rectangle GetBoundingBox()
        {
            return shape.GetBoundingBox();
        }
    }
}
