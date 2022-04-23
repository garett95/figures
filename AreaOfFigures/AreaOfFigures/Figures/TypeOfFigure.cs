using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    // вычисление площади фигуры без знания типа фигуры
    public class TypeOfFigure : IShape
    {
        private IShape shape;
        public double Area
        {
            get
            {
                return shape.Area;
            }
        }

        public TypeOfFigure(IShape figure)
        {
            shape = figure;
        }
    }
}
