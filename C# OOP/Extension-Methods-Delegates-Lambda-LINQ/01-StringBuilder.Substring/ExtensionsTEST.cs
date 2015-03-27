using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
 and has the same functionality as Substring in the class String.*/

namespace _01_StringBuilder.Substring
{
    class ExtensionsTEST
    {
        static void Main(string[] args)
        {
            string input = "OneTwoThreeFourFive";

            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            Console.WriteLine(sb.Substring(6, 5));
        }
    }
}
