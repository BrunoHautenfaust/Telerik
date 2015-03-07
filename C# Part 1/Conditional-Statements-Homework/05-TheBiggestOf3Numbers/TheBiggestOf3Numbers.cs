using System;


namespace _05_TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            // Write a program that finds the biggest of three numbers.

            Console.WriteLine("Input number 1:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            double c = double.Parse(Console.ReadLine());

            double biggest = Math.Max(c, Math.Max(a, b));
            Console.WriteLine(biggest);

        }
    }
}
