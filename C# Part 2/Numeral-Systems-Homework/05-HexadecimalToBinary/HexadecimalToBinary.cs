using System;

    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            // Write a program to convert hexadecimal numbers to binary numbers (directly).

            Console.WriteLine("Input a hexadecimal number:");
            string number = Console.ReadLine();
            number = Convert.ToString(Convert.ToInt32(number, 16), 2);
            Console.WriteLine("Binary representation: {0}", number);
        }
    }

