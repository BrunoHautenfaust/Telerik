using System;
using System.Text;

class ForbiddenWords
{
    /*We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] array = text.Split(' ', '.');

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "PHP" || array[i] == "CLR" || array[i] == "Microsoft")
            {
                char[] charArr = array[i].ToCharArray();
                string mid = String.Empty;

                for (int j = 0; j < charArr.Length - 1; j++)
                {
                    charArr[j] = '*';
                    StringBuilder sb = new StringBuilder();
                    sb.Append(charArr[j]);
                    mid = sb.ToString();
                    Console.Write(mid);

                }
                array[i] = array[i].Replace(array[i], mid);
            }
            Console.Write(array[i] + " ");
        }
    }
}

