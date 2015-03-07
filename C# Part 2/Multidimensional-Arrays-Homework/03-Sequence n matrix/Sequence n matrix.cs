using System;

class Program
{
    static void Main(string[] args)
    {
        /*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
       Write a program that finds the longest sequence of equal strings in the matrix.*/
        /*
        string[,] matrix = {
               { "fo",	"fifi",	"ho",	"xx" },
               { "fo",	"fo",	"xx",	"zz" },
               { "ad",	"xx",	"hi",	"zz" }
                           };
        */

        Console.WriteLine("Input N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Input M");
        int M = int.Parse(Console.ReadLine());

        string[,] matrix = new string[N, M];

        // fill array
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("matrix[{0}, {1}] = ", i, j);
                matrix[i, j] = Console.ReadLine();
            }
        }


        string bestSequence = String.Empty;
        int bestCount = 0;
        int row = 0;
        int col = 0;
        string searchedString = matrix[row, col];
        int count = 1;

        // Diagonal check(left to right):  // ok
        while (row + 1 < matrix.GetLength(0) - 1 || col + 1 < matrix.GetLength(1) - 1)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            row++;
            col++;

        }
        if (count > bestCount)
        {
            bestCount = count;
            bestSequence = searchedString;
        }

        // Horizontal check:    // ok
        row = 0;
        col = 0;
       
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1)-1; col++)
            {
                searchedString = matrix[row, col];

                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestSequence = searchedString;
                }
            }
            
        }

        // Vertical check:    // ok  
        row = 0;
        col = 0;

        for (col = 0; col < matrix.GetLength(1); col++)                
        {
            for (row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                searchedString = matrix[row, col];

                if ((matrix[row, col] == matrix[row+1, col]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestSequence = searchedString;
                }
            }

        }

        Console.WriteLine("Most frequent string: "+bestSequence);
        Console.WriteLine("Count: "+bestCount);
    }
}



