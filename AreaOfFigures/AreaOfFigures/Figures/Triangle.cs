using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public class Triangle: IShape
    {
        // стороны треугольника
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        // вычисление площади по трем сторонам 
        public double Area
        {
            get
            {
                double p = (A + B + C) / 2;  // полупериметр треугольника
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // площадь треугольника
            }
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        //проверка является ли треугольник прямоугольным
        public bool RightTriangle()
        {
            return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) || A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
        }
    }
}
