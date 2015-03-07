using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Palindromes
{
    class Palindromes
    {
        //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

        static void Main(string[] args)
        {
            string text = @"
Lorem ipsum dolor sit amet, consectetur ABBA adipiscing elit. Nulla vehicula ac sem eu lamal malesuada. Donec urna ipsum, iaculis ac exe mi sed, elementum vulputate turpis. Nam dignissim eros purus, non tristique velit facilisis non.";

            string[] arr = text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(new string(arr[i].Reverse().ToArray()))  )
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
