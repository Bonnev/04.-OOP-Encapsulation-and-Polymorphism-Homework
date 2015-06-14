using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    static class Shapes
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Rectangle(10, 5);
            shapes[1] = new Circle(3);
            shapes[2] = new Triangle(10, 5, 7);
            foreach (IShape shape in shapes)
            {
                Console.WriteLine("{0}: area: {1:0.00} perimeter: {2:0.00}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
