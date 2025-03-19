using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OOP_lr4_1
{
    public partial class frmMain : Form
    {
        MyStorage<CShape> shapes;
        Color currentColor;
        string currentShape;
        int dx = 5, dy = 5, da = 5;

        public frmMain()
        {
            InitializeComponent();
            shapes = new MyStorage<CShape>();
            currentColor = Color.Red;
            currentShape = "Circle";
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                chbCtrl.Checked = true;
            }
            else if(e.KeyCode == Keys.Delete)
            {
                // те объекты, которые являются декораторами, удаляем


                // последний объект в списке делаем декоратором (если не пустой список)


                // обновляем pictureBox (вызывается событие Paint)
                pictureBox.Invalidate();
            }
            else if(e.KeyCode == Keys.Up)
            {
                // те, которые декорированы, двигаем


            }
            else if (e.KeyCode == Keys.Down)
            {
                // те, которые декорированы, двигаем

            }
            else if (e.KeyCode == Keys.Left)
            {
                // те, которые декорированы, двигаем

            }
            else if (e.KeyCode == Keys.Right)
            {
                // те, которые декорированы, двигаем

            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                // те, которые декорированы, уменьшаем

            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                // те, которые декорированы, увеличиваем

            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey && chbCtrl.Checked == true)
            {
                chbCtrl.Checked = false;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // рисуем все объекты из контейнера
            for (int i = 0; i < shapes.getSize(); ++i)
            {
                shapes.getObject(i).Draw(e.Graphics);
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // если зажат Ctrl и кликнули ЛКМ
            if (chbCtrl.Checked && e.Button == MouseButtons.Left)
            {
                
                    
            }
            else
            {
                CShape shape;
                switch (currentShape)
                {
                    case "Circle":
                        shape = new CCircle(e.X, e.Y, currentColor);
                        break;
                    case "Square":
                        shape = new CSquare(e.X, e.Y, currentColor);
                        break;
                    case "Triangle":
                        shape = new CTriangle(e.X, e.Y, currentColor);
                        break;
                    default:
                        shape = new CCircle(e.X, e.Y, currentColor);
                        break;
                }

                shapes.pushBack(shape);

            }
            // обновляем pictureBox (вызывается событие Paint)
            pictureBox.Invalidate();
        }

        private void menuBtnCircle_Click(object sender, EventArgs e)
        {
            currentShape = "Circle";
        }

        private void menuBtnSquare_Click(object sender, EventArgs e)
        {
            currentShape = "Square";
        }

        private void menuBtnTriangle_Click(object sender, EventArgs e)
        {
            currentShape = "Triangle";
        }

        private void menuColorRed_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
        }

        private void menuColorBlue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
        }

        private void menuColorYellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
        }

        private void menuColorGreen_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
        }

        private void menuColorBlack_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }
    }
}
