using System;
using System.Numerics;

class NFactorial
{
    static void Main(string[] args)
    {
        // Write a program to calculate n! for each n in the range [1..100].

        int n = 0;

        do
        {
            Console.WriteLine("Input n:");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0 || n > 100);

        FactorialForN(n);

    }

    public static void FactorialForN(int n)
    {
        BigInteger fact = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
            }
            Console.WriteLine("{0}! = {1}", i, fact);
            fact = 1;
        }
    }
}

