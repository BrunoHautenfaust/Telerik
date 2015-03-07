using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)    
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

            int n = 0;
            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            while (n < 1 || n > 20);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");
                for (int j = i + 1; j < n+i; j++)   
                {
                    Console.Write(j+" ");
                }
              
                Console.WriteLine();
            }

        }
    }
}
