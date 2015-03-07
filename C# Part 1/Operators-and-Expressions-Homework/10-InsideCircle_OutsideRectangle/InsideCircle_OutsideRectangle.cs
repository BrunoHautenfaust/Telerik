using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InsideCircle_OutsideRectangle
{
    class InsideCircle_OutsideRectangle
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

            Console.WriteLine("Input x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input y:");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5);
            bool OutRectangle = y > 1;

            if (inCircle == true && OutRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
