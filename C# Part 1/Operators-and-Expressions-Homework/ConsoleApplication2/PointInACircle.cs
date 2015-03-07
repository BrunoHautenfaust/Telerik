using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

            Console.WriteLine("Input X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Y:");
            double y = double.Parse(Console.ReadLine());
            bool inside = true;
         
            if ((x*x)+(y*y) <= (2*2))
            {
                Console.WriteLine(inside);
            }
            else
            {
                Console.WriteLine(!inside);
            }

        }
    }
}
