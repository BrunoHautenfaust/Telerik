using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTEST
    {
        static void Main(string[] args)
        {
            int row = 4, col = 5;
            var matrix1 = new Matrix<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 10;
                }
            }

            Console.WriteLine("Matrix 1:\n" + matrix1);

            row = 5;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = r + c;
                }
            }
            Console.WriteLine("Matrix 2:\n" + matrix2);

           // Console.WriteLine("Addition:\n{0}", matrix1 + matrix2); // Matrices must have equal dimensions for the operation to work.
           // Console.WriteLine("Substraction:\n{0}", matrix1 - matrix2); // Matrices must have equal dimensions for the operation to work.
            Console.WriteLine("Multiplication:\n" + (matrix1 * matrix2));

            if (matrix2)
            {
                Console.WriteLine("Matrix 2 has NO zeros.");
            }
            else
            {
                Console.WriteLine("Matrix 2 has zeros.");
            }
            Console.WriteLine();



        }
    }
}
