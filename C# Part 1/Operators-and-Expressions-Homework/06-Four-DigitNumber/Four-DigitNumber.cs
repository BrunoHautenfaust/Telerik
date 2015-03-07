using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Four_DigitNumber
{
    class Four_DigitNumber
    {
        static void Main(string[] args)
        {
            /*
             Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
             */

            string text;
            do
            {
                Console.WriteLine("Input a 4-digit integer:");
                text = Console.ReadLine();
            }
            //          FALSE       &&          TRUE
            while ((text.Length != 4) || (text.StartsWith("0")));
            
            int num = int.Parse(text);
            
           // int num = 2011;
            int d = num % 10;
            int c = (num / 10) % 10;
            int b = (num / 100) % 10;
            int a = (num / 1000) % 10;
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine("Sum = " + (a + b + c + d));
            Console.WriteLine("Reversed order -> "+ d+c+b+a);
            Console.WriteLine("Last digit in the first position -> "+d+a+b+c);
            Console.WriteLine("Exchanged second and third digit -> "+ a+c+b+d);
        }
    }
}
