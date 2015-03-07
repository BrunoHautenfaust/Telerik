using System;

namespace _06_TheBiggestOf5Numbers
{
    class TheBiggestOf5Numbers
    {
        static void Main()
        {
        // Write a program that finds the biggest of five numbers by using only five if statements.

            Console.WriteLine("Input number 1:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 4:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 5:");
            double e = double.Parse(Console.ReadLine());

            double biggest = double.MinValue;
          
     /*1*/  if (biggest < a)
            {
                biggest = a;
            }
     /*2*/  if (biggest < b)
            {
                biggest = b;
            }
     /*3*/  if (biggest < c)
            {
                biggest = c;
            }
     /*4*/  if (biggest < d)
            {
                biggest = d;
            }
     /*5*/  if (biggest < e)
            {
                biggest = e;
            }
            Console.WriteLine(biggest);
        }
    }
}
