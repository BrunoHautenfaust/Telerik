using System;
using System.Text;

class StringLength
{

    /*Write a program that reads from the console a string of maximum 20 characters.
   * If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/

    static void Main(string[] args)
    {
        // Ex. "12345678901234567890" Length is 20 characters
        string text = String.Empty;

        do
        {
            Console.WriteLine("Write some text (MAX length: 20 characters):");
            text = Console.ReadLine();
        } while (text.Length > 20);

        if (text.Length == 20)
        {
            Console.WriteLine(text);
        }
        else if (text.Length < 20)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            while (sb.Length < 20)
            {
                sb.Append('*');
            }
            Console.WriteLine(sb.ToString());
          
        }
    }
}

