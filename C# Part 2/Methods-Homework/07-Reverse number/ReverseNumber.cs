using System;

    class ReverseNumber
    {
        static void Main(string[] args)
        {
            // Write a method that reverses the digits of given decimal number.

            Console.WriteLine("Input a number:");
            string number = Console.ReadLine();
            ReversedNumber(number);

        }

        static void ReversedNumber(string n)
        {
            char[] arr = n.ToCharArray();
            Array.Reverse(arr);
            Console.Write(arr);
            Console.WriteLine();
        }

    }

