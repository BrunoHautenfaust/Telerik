using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class TESTProgram
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(2.5, 4),
                new Rectangle(3, 5.5),
                new Square(4, 4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} surface = {1}", shape, shape.CalculateSurface());
            }

        }
    }
}
