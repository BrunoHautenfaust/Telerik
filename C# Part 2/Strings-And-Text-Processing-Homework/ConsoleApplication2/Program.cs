using System;
using System.Text;
class UnicodeCharacters
{
    static void Main()
    {
        /*Write a program that converts a string to a sequence of C# Unicode character literals.
        Use format strings.*/

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