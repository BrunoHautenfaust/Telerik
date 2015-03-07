using System;


namespace _04_MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
     /*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.*/

            Console.WriteLine("Input number 1:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            double c = double.Parse(Console.ReadLine());
            if (a * b * c > 0)
            {
                Console.WriteLine('+');
            }
            else if (a * b * c < 0)
            {
                Console.WriteLine('-');
            }
            else
            {
                Console.WriteLine('0');
            }
        }
    }
}
