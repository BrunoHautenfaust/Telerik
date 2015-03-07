using System;
using System.Text;

class UnicodeCharacters
{
    /*
     Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
Example:

input	    output
Hi!    	\u0048\u0069\u0021
*/
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder converted = new StringBuilder();

        foreach (var ch in input)
        {
            converted.AppendFormat("\\u{0:X4}", (int)ch);
        }

        Console.WriteLine(converted.ToString());
    }
}
