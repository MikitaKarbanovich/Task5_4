using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectanle = new Rectangle(5, 10);
            Figure figure = new Figure(120);
            figure.GetQuantityOfRectanglesInFigure(rectanle.GetAreaOfRectangle());
            Console.WriteLine(figure.ToString());
            Console.ReadKey();

        }
    }
}
