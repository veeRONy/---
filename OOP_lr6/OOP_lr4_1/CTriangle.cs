using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    internal class CTriangle : CShape 
    {
        private Point[] points = new Point[3]; // 3 точки треугольника
        private int a; // длина стороны треугольника
        private Pen pen;
        private int x, y;

        public CTriangle(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            a = 80;

            points[0].X = x - a / 2;
            points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[1].X = x + a / 2;
            points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[2].X = x;
            points[2].Y = y - Convert.ToInt32(a * Math.Sqrt(3) / 3);

            pen = new Pen(color);
        }
        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, points);
        }

        public override CShape GetRealObject()
        {
            return this;
        }

        public void Move(int dx, int dy)
        {
            points[0].X += dx;
            points[1].X += dx;
            points[2].X += dx;
            x = points[0].X + a / 2;

            points[0].Y += dy;
            points[1].Y += dy;
            points[2].Y += dy;
            y = points[0].Y - Convert.ToInt32(a * Math.Sqrt(3) / 6);
        }

        public void ChangeSize(int da)
        {
            a += da;
            points[0].X = x - a / 2;
            points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[1].X = x + a / 2;
            points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[2].X = x;
            points[2].Y = y - Convert.ToInt32(a * Math.Sqrt(3) / 3);
        }
    }
}
