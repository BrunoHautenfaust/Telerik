using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FormattingNumbers
{
    class FormattingNumbers     
    {
        static void Main(string[] args)
        {
            /*Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
        The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.*/

            int a = 0;
            do
            {
                Console.WriteLine("Input an integer(0 <= a <= 500):");
                a = int.Parse(Console.ReadLine());
            } while (a < 0 || a > 500);
            Console.WriteLine("Input floating-point b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input floating-point c:");
            double c = double.Parse(Console.ReadLine());
            string aBin = Convert.ToString(a, 2).PadLeft(10, '0');

            string formatA = "{0,-10:X}";
            string formatB = "{0,10:F2}";
            string formatC = "{0,-10:F3}";

            // Output:
            Console.Write(formatA, a);
            Console.Write("| "+ aBin);
            Console.Write("| "+ formatB, b);
            Console.Write("| "+ formatC, c);

        }
    }
}
