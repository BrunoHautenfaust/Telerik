using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Square : Shape
    {

        public Square(double width, double height)
        {
            if (width != height)
            {
                throw new ArgumentException("height and width must be equal!");
            }
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return Height * Height;
        }

        public override string ToString()
        {
            return string.Format("Square");
        }
    }
}
