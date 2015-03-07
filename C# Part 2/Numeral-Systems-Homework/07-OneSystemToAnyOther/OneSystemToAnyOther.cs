using System;

class OneSystemToAnyOther
{
    static void Main(string[] args)
    {
        // Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

        int s = 0;
        int d = 0;
        do
        {
        Console.WriteLine("Input base (2-16):");
         s = int.Parse(Console.ReadLine());
        } while (s < 2 || s > 16);

        Console.WriteLine("Input a number to convert:");
        string number = Console.ReadLine();

        do
        {
        Console.WriteLine("Choose conversion base (2-16):");
        d = int.Parse(Console.ReadLine());
        } while (d < 2 || d> 16);

        
    }
}

