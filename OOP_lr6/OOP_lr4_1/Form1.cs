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
        int dx = 1, dy = 1, da = 1;
        int s = 5;

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
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.erase(i);
                        --i;
                    }
                }

                // последний объект в списке делаем декоратором (если не пустой список)
                if (shapes.getSize() != 0)
                {
                    CDecorator decorator = new CDecorator(shapes.last());
                    shapes.setObject(shapes.getSize()-1, decorator);
                }

                // обновляем pictureBox (вызывается событие Paint)
                //pictureBox.Invalidate();
            }
            else if(e.KeyCode == Keys.W)
            {
                // те, которые декорированы, двигаем вверх
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is IMovable movable)
                        for (int j = 0; j < s; ++j)
                            if (movable.CanMoveY(-dy, pictureBox.Height))                      
                                movable.Move(0, -dy);
                }

            }
            else if (e.KeyCode == Keys.S)
            {
                // те, которые декорированы, двигаем вниз
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is IMovable movable)
                        for (int j = 0; j < s; ++j)
                            if (movable.CanMoveY(dy, pictureBox.Height))
                                movable.Move(0, dy);
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                // те, которые декорированы, двигаем влево
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is IMovable movable)
                        for (int j = 0; j < s; ++j)
                        if (movable.CanMoveX(-dx, pictureBox.Width))
                            movable.Move(-dx, 0);
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                // те, которые декорированы, двигаем
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is IMovable movable)
                        for (int j = 0; j < s; ++j)
                            if (movable.CanMoveX(dx, pictureBox.Width))
                                movable.Move(dx, 0);
                }
            }
            else if (e.KeyCode == Keys.Z)
            {
                // те, которые декорированы, уменьшаем
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is ISizable sizable)
                        for (int j = 0; j < s; ++j)
                            if (sizable.CanChangeSize(-da, pictureBox.Width, pictureBox.Height))
                                sizable.ChangeSize(-da);
                }
            }
            else if (e.KeyCode == Keys.X)
            {
                // те, которые декорированы, увеличиваем
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator && decorator.GetRealObject() is ISizable sizable)
                        for (int j = 0; j < s; ++j)
                            if (sizable.CanChangeSize(da, pictureBox.Width, pictureBox.Height))
                                sizable.ChangeSize(da);
                }
            }

            pictureBox.Invalidate();
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
                // делаем объект, на который кликнули, декоратором
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    var shape = shapes.getObject(i).GetRealObject();
                    if (shape is IClickable clickable && clickable.isClicked(e.X, e.Y))
                    {
                        // Обработка клика
                        CDecorator decorator = new CDecorator(shape);
                        shapes.setObject(i, decorator);

                        // если включено выделение только одного круга, то прерываем цикл
                        // иначе продолжаем выделять те круги, на которые кликнули
                        if (chbSelectOnlyOne.Checked == true)
                            break;
                    }
                    
                }
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
                // заворачиваем новый объект в декоратор
                CDecorator decorator = new CDecorator(shape);

                // заменяем все декораторы из списка реальными объектами
                for(int i = 0; i < shapes.getSize(); ++i)
                {
                    var realObject = shapes.getObject(i).GetRealObject();  
                    shapes.setObject(i, realObject);
                }

                // добавляем декоратор в список
                shapes.pushBack(decorator);

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
