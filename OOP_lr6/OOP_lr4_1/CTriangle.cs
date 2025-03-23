using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    internal class CTriangle : CShape, IClickable, IMovable, ISizable
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

            // левая точка
            points[0].X = x - a / 2;
            points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            // правая точка
            points[1].X = x + a / 2;
            points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            // верхняя точка
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

        public override Rectangle GetBoundingBox()
        {
            int minX = points.Min(p => p.X);
            int minY = points.Min(p => p.Y);
            int maxX = points.Max(p => p.X);
            int maxY = points.Max(p => p.Y);
            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }

        public bool isClicked(int X, int Y)
        {
            // (x1-x0)*(y2-y1)-(x2-x1)*(y1-y0)
            int a1 = (points[0].X - x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - y);

            // (x2-x0)*(y3-y2)-(x3-x2)*(y2-y0)
            int a2 = (points[1].X - x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - y);

            // (x3-x0)*(y1-y3)-(x1-x3)*(y3-y0)
            int a3 = (points[2].X - x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - y);

            if ((a1 >= 0 && a2 >= 0 && a3 >= 0) || (a1 <= 0 && a2 <= 0 && a3 <= 0))
                return true;
            else
                return false;
        }

        public bool CanMoveX(int dx, int width)
        {
            return ((points[0].X + dx) >= 0 && (points[1].X + dx) < width);
        }

        public bool CanMoveY(int dy, int height)
        {
            return ((points[2].Y + dy) >= 0 && (points[0].Y + dy) < height);
        }

        int minSize = 5;
        public bool CanChangeSize(int da, int width, int height)
        {
            if (da < 0)
                return (a + da >= minSize);
            else
                return ((points[2].Y - da >= 0) && (points[0].Y + da < height) && (points[0].X - da >= 0) && (points[1].X + da < width));
        }
    }
}
