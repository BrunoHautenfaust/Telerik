using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Maximal_area_sum
{
    class MaximalAreaSum
    {
        /*Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

        input	        output
        4 
        2 3 3 4 
        0 2 3 4           17
        3 7 1 2 
        4 3 3 2
         */

        static void Main(string[] args)      // All text files are in the CURRENT PROJECT FOLDER
        {
       
           int result = FindMaxSum( ReadAndFillMatrix() );

            using(StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(result);
                Console.WriteLine("Result was written in \"output.txt\".");
            }

        }

        private static int FindMaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)     
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }

        private static int[,] ReadAndFillMatrix()
        {
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                int n = int.Parse(reader.ReadLine());
                int[,] matrix = new int[n, n];

                string rows;

                for (int row = 0; row < n; row++)
                {
                    rows = reader.ReadLine();       // Read line
                    string[] cells = rows.Split(' ');   // Remove space and convert to array

                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(cells[col]);   // Fills matrix with each row of string[] cells
                    }
                }
                return matrix;

                /*
              // PRINT MATRIX:
              for (int row = 0; row < matrix.GetLength(0); row++)
              {
                  for (int col = 0; col < matrix.GetLength(1); col++)
                  {
                      Console.Write(matrix[row, col] + " ");
                  }
                  Console.WriteLine("\n");
              }
              */
            }
        }
    }
}
