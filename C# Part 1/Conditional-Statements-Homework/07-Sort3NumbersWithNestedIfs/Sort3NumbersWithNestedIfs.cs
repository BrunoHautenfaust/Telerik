using System;

namespace _07_Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            /*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

            Console.WriteLine("Input number 1:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            double c = double.Parse(Console.ReadLine());

            double biggest = 0, middle = 0, smallest = 0;

            // biggest is a
            if(a>b && a>c)
            {
                biggest = a;
                if (b>c)
                {
                    middle = b;
                    smallest = c;
                }
                else
                {
                    middle = c;
                    smallest = b;
                }
            }
            // biggest is b
            if (b>a && b>c)
            {
                biggest = b;
                if(a>c)
                {
                    middle = a;
                    smallest = c;
                }
                else
                {
                    middle = c;
                    smallest = a;
                }
            }
            // biggest is c
            if (c>a && c>b)
            {
                biggest = c;
                if (b>a)
                {
                    middle = b;
                    smallest = a;
                }
                else
                {
                    middle = a;
                    smallest = b;
                }
            }
            if (a==b && b ==c)
            {
                biggest = a;
                middle = b;
                smallest = c;
            }
            Console.WriteLine(biggest+" " + middle+" "+smallest);
        }
    }
}
