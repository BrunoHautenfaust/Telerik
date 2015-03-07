using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).*/

            Console.WriteLine("Input a:");
           int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
           int b = int.Parse(Console.ReadLine());

           int q = a % b;

           Console.WriteLine("The GCD for {0} and {1} is {2}", a, b, q);
        }
    }
}
