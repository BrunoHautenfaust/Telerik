using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads 3 real numbers from the console and prints their sum.

          Console.WriteLine("Input a:");
          double a = double.Parse(Console.ReadLine());
          Console.WriteLine("Input b:");
          double b = double.Parse(Console.ReadLine());
          Console.WriteLine("Input c:");
          double c = double.Parse(Console.ReadLine());
          double sum = a + b + c;
          Console.WriteLine(sum);

        }
    }
}
