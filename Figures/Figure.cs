using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Figure
    {

        PointF coord = new PointF();  // координаты
        public static int countCorners = 2;  //количество вершин
        public Figure()
        {
            countCorners++;
        }
        
        //Координты вершин многоугольника 
        public static IEnumerable<PointF> CornersCoordinates(PointF center, int radius, int corners)
        {

            var angle = Math.PI * 2 / corners;
            //Точки многоугольника
            var points = Enumerable.Range(0, corners)
                    .Select(i => PointF.Add(center, 
                    new SizeF((float)Math.Sin(i * angle) * radius, 
                              (float)Math.Cos(i * angle) * radius)));
            return points;
        }


        public void DrawRectangle(Graphics g)  //прямоугольник
        {
            g.FillRectangle(Brushes.Red, coord.X, coord.Y, 100, 70);
        }
        public void DrawSquare(Graphics g)  //квадрат
        {
            g.FillRectangle(Brushes.Red, coord.X, coord.Y, 100, 100);
        }
        public void DrawTriangle(Graphics g)  //треугольник 
        {
            PointF coordd = new PointF(coord.X+50, coord.Y+50);  // двигаем координаты, чтобы фигура поместилась в picturebox
            g.FillPolygon(Brushes.Black, CornersCoordinates(coordd, 50, 3).ToArray());
        }
        public void DrawCircle(Graphics g)  //круг
        {
            g.FillEllipse(Brushes.Black, coord.X, coord.Y, 100, 100);
        }

        //рисуем любой правильный многоугольник, начиная с трегольника
        public void DrawRegularPolygon( Graphics g)
        {

            PointF coordd = new PointF(coord.X + 50, coord.Y + 50);
            g.FillPolygon(Brushes.Blue, CornersCoordinates(coordd, 50, countCorners).ToArray());   //corners - количество вершин

        }
    }
}
