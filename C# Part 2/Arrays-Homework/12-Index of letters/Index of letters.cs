using System;

class Program
{
    static void Main(string[] args)
    {
        /*Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/

        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        Console.WriteLine("Input a word:");
        string word = Console.ReadLine();

        // Convert string to char array
        char[] c = word.ToCharArray();
        //  Array.ForEach(c, x => Console.WriteLine(x));

        foreach (char element in c)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (char.ToUpperInvariant(element) == alphabet[i])
                {
                    Console.WriteLine("Letter: {0} ----> Index: {1}", element, i);
                }
            }


        }
    }
}