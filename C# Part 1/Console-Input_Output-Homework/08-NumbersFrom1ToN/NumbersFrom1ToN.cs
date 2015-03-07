using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

            Console.Write("Input a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
