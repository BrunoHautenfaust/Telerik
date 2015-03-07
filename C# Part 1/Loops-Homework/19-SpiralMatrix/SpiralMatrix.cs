using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
    /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.*/

            int n = 1;
         
            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 20);

            int[,] arr = new int[n*n, n*n];
    //        Console.WriteLine(arr.Length);

            for (int row = 0; row <arr.Length; row++)
			{
                for (int col = 0; col < arr.Length; col++)
                {
			         arr[row, col] = row+1;
                }
			}

        }
    }
}
