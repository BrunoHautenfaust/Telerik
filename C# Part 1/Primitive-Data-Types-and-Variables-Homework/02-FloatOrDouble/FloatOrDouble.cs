using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            /*
             * Which of the following values can be assigned to a variable
             * of type float and which to a variable of type double:
             * 34.567839023, 12.345, 8923.1234857, 3456.091?
               Write a program to assign the numbers in variables and print them to ensure no precision is lost.
             */

            double num1 = 34.567839023;
            float num2 = 12.345F;
            double num3 = 8923.1234857;
            float num4 = 3456.091F;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

        }
    }
}
