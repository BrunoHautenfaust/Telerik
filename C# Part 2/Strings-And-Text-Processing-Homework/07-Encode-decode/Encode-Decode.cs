using System;
using System.Text;

class Program
{
    /*Write a program that encodes and decodes a string using given encryption key (cipher).
 The key consists of a sequence of characters.
 The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.*/

    static void Main(string[] args)
    {
        Console.WriteLine("Input text to encript:");
        // string text = "text";
        string text = Console.ReadLine();
        Console.WriteLine("Input encription key:");
        // string key = "key";
        string key = Console.ReadLine();
        int j = 0;
        char[] charArr = text.ToCharArray();

        for (int i = 0; i < charArr.Length; i++)
        {
            for (j = j; j < key.Length; j++)
            {
                charArr[i] ^= key[j];
                break;
            }
            j++;
            if (j > key.Length - 1)
            {
                j = 0;
            }
        }
        text = new string(charArr);
        Console.WriteLine("The encripted text is: {0}", text);
        // Console.WriteLine(text);
    }
}
