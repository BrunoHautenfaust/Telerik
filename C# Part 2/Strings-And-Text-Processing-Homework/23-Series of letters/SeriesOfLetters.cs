using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Series_of_letters
{
    class SeriesOfLetters
    {
        /*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                    output
aaaaabbbbbcdddeeeedssaa 	abcdedsa*/

        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string text = Console.ReadLine(); // aaaaabbbbbcdddeeeedssaa

            StringBuilder sb = new StringBuilder();

            char previous = text[0];

            sb.Append(previous);

            for (int i = 1; i < text.Length; i++)
            {
                if (previous != text[i])
                {
                    sb.Append(text[i]);
                }
                previous = text[i];

            }
            string result = sb.ToString();
            Console.WriteLine(result);

          

        }
    }
}
