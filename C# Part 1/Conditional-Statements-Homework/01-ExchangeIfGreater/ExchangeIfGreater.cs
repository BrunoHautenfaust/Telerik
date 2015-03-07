using System;

namespace _01_ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            // Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
            Console.WriteLine("Input number 1:");
            double a = double.Parse(Console.ReadLine());
              Console.WriteLine("Input number 2:");
            double b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                double c;
                c = a;
                a = b;
                b = c;
            }
            Console.WriteLine(a+" "+b);
                


        }
    }
}
