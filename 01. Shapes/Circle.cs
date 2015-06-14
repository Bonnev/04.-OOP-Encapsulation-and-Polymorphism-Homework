using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Circle:IShape
    {
        private double radius;
        public double Radius {
            get { return radius; }
            private set
            {
                if (value <= 0) throw new InvalidDataException("Radius should have a non-negative value.");
                radius = value;
            }}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI*Radius*Radius;
        }

        public double CalculatePerimeter()
        {
            return 2*Math.PI*Radius;
        }
    }
}
