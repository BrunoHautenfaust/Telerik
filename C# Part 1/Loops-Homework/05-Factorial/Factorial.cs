using System;

    class Factorial
    {
        static void Main(string[] args)
        {
            /*Write a program that, for a given two integer numbers n and x, calculates the sum
            S = 1 + 1!/x + 2!/x^2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

            Console.WriteLine("Input integer 1:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input integer 2:");
            int x = int.Parse(Console.ReadLine());
           
            int factorial = 1;
            double power = 1;
            double S = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = Math.Pow(x, i);
                S += factorial / power;
            }

            Console.WriteLine(S.ToString("0.00000"));
        }
    }
