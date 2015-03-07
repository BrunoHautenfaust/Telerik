using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            /*Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();

            int result = 0;
            for (int bit = 0; bit < binary.Length; bit++)
            {
                result *= 2;
                result += int.Parse(binary[bit].ToString());
            }
            Console.WriteLine(result);
        }
    }
}
