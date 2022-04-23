using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    public  class Circle :IShape
    {
        public int Radius { get; set; } 
        //вычисление площади круга по радиусу 
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

  
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
}
