using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_RandomizeTheNumbers1_N
{
    class Program
    {
        static void Main(string[] args)
        {
         // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

            int n = 0;
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
                
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(r.Next(0, n+1) + ", ");
            }
        }
    }
}
