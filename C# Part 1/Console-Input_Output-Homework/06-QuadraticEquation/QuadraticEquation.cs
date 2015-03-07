using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
        // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

           Console.WriteLine("Input a:");
           double a = double.Parse(Console.ReadLine());
           Console.WriteLine("Input b:");
           double b = double.Parse(Console.ReadLine());
           Console.WriteLine("Input c:");
           double c = double.Parse(Console.ReadLine());

           double D = b*b - 4*a*c;
          // Console.WriteLine("D= "+D);
            if (D>0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
            }
            else if(D==0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x= "+x);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}
