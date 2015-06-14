using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : BasicShape
    {
        private double side;
        public double Side
        {
            get { return side; }
            private set
            {
                if (value < 0) throw new InvalidDataException("Side should have a non-negative value.");
                if (value <= Height) throw new InvalidDataException("Side is less than the height -> impossible triangle");
                side = value;
            }
        }

        public override double CalculateArea()
        {
            return height * width / 2;
        }

        public override double CalculatePerimeter()
        {
            double widthPart = Math.Sqrt(Math.Abs(Math.Pow(Side, 2) - Math.Pow(Height, 2)));
            double widthOtherPart = Width - widthPart;
            double otherSide = Math.Sqrt(Math.Pow(widthOtherPart, 2) + Math.Pow(Height, 2));
            return Side + otherSide + Width;
        }

        public Triangle(double width, double height, double side)
            : base(width, height)
        {
            Side = side;
        }
    }
}
