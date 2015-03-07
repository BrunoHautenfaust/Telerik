using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
      // Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

            Console.WriteLine("Input r:");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;          
            double P = 2 * r * pi;
            double A = r * r * pi;
            Console.WriteLine("Perimeter = {0:0.00}\nArea = {1:F2}", P, A);
        }
    }
}
