using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class mainForm : Form
    {
        
        PointF click;

        PictureBox pb = new PictureBox() { Width = 100, Height = 100 };  //создаем контейнер для рисования 
        bool clickDown = false;
        public static Color FormBackColor { get; set; }
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:

                 
                    pb.BackColor = Color.Transparent;                               //  с прозрачным фономо
                    pb.Location = new Point(e.Location.X, e.Location.Y);           //на месте клика 
                    Figure f = new Figure();                                       //объект для рисования фигур
                           
                    Bitmap bitmap = new Bitmap(pb.Width, pb.Height);               //превращаем геометрические фигуры в рисунок
                    
                    Graphics g = Graphics.FromImage(bitmap);

                    pb.Image = bitmap;                                     //записываем рисунок в pictirebox
                    Controls.Add(pb);                                      //добавляем picturebox на форму
                     

                    pb.MouseDown += (s, a) => { clickDown = true; };        //обработчик событий при нажатии левой кнопки мыши
                    pb.MouseUp += (s, a) => { clickDown = false; };        //обработчик событий при отпускании левой кнопки мыши
                    pb.MouseMove += (s, a) =>                              // перемещение мышки 
                    {
                        Cursor.Current = Cursors.SizeAll;                 //меняем курсор при наведении  
                        if (clickDown)
                        {
                            //перемещаем фигуру 
                            pb.Location = new Point((Cursor.Position.X - this.Location.X - 50), (Cursor.Position.Y - this.Location.Y - 50));
                        }

                    };
                 



                    if (RbPolygon.Checked)
                     {
                        f.DrawRegularPolygon(g);
                     }
                     if (RbReactangle.Checked)
                     {
                        f.DrawRectangle(g);
                     }
                     if (RbCircle.Checked)
                     {
                        f.DrawCircle(g);
                     }
                     if (RbSquare.Checked)
                     {
                        f.DrawSquare(g);
                     }
                     if (RbTriangle.Checked)
                     {
                        f.DrawTriangle(g);
                     }
                    break;

                    //удаляем фигуры
                case MouseButtons.Right:
                                 
                    if (Figure.countCorners > 2)
                    {
                        Controls.Remove(pb);
                        Figure.countCorners = 2;
                    }
                    else
                    {
                        MessageBox.Show("На поле нет фигур для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
           
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Figure.countCorners > 2)
            {
                Controls.Remove(pb);
                Figure.countCorners = 2;
            }
            else
            {
                MessageBox.Show("На поле нет фигур для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            FormBackColor = this.BackColor;
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) При нажатии курсором по области окна,в месте нажатия рисуется фигура." +
               "\n 2)Если выбран режим Многоульник, то при нажатии на форму, рисуется правильный многоугольник и при каждом клике увеличивается количество углов." +
               "\n3)При выборе других режимов, рисуется выбранная фигура."+
               " \n4)Кнопка Delete удаляет все размещеныые фигуры.");
        }
    }
}
