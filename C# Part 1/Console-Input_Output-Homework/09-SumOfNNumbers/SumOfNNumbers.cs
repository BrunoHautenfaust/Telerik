using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

            Console.Write("Input a number:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Input number No.{0}:", i);
                double d = double.Parse(Console.ReadLine());
                sum += d;
            }
            Console.WriteLine(sum);
        }
    }
}
