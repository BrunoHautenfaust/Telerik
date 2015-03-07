using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _18_TrailingZeroesInN_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

            BigInteger fact = 1;
            int zeros = 0;
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
      
            while(fact % 10 == 0)
            {
                fact /= 10;
                zeros++;
            }
            Console.WriteLine(zeros);
        }
    }
}
