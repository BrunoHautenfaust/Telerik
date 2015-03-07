using System;

    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            // Write a program to convert binary numbers to hexadecimal numbers (directly).

            Console.WriteLine("Input a binary number:");
            string number = Console.ReadLine();
            number = Convert.ToString(Convert.ToInt32(number, 2), 16);
            Console.WriteLine("Hexadecimal representation: {0}", number);
        }
    }

