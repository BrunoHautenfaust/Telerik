using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates trapezoid's area by given sides a and b and height h.

            double a = 5;
            double b = 7;
            double h = 12;
            double area = ((a+b)/2)*h;
            Console.WriteLine(area);
        
        }
    }
}
