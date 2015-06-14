using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Rectangle : BasicShape
    {
        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (width + height);
        }

        public Rectangle(double width, double height)
            : base(width, height)
        {
        }
    }
}
