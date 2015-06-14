using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    abstract class BasicShape:IShape
    {
        protected double width;
        protected double height;

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0) throw new InvalidDataException("Width should have a non-negative value.");
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0) throw new InvalidDataException("Height should have a non-negative value.");
                height = value;
            }
        }

        public BasicShape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
