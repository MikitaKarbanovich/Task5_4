using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetAreaOfRectangle()
        {
           return Width* Height;
        }
    }
    class Figure
    {
        public double AreaOfFigure { get; set; }
        public double QuantityOfRectangles { get; set; }
        public Figure(double areaOfFigure)
        {
            AreaOfFigure = areaOfFigure;
        }
        public double GetQuantityOfRectanglesInFigure(double areaOfRectangle)
        {
            return QuantityOfRectangles=AreaOfFigure/areaOfRectangle;
        }
        public override string ToString()
        {
            string result = string.Format("{0:0.##}", QuantityOfRectangles);
            return $"Result is: {result}";
        }
    }
}
