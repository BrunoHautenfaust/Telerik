using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Format_number
{
    class FormatNumber
    {
        /*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal: {0, 15:F}", d);
            Console.WriteLine("Hex: {0, 15:X}", d);
            Console.WriteLine("Percent: {0, 15:P}", d);
            Console.WriteLine("Scientific Notation: {0, 15:E}", d);
        }
    }
}