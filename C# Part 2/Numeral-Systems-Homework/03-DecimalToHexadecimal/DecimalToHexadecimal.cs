using System;
using System.Collections.Generic;

    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            // Write a program to convert decimal numbers to their hexadecimal representation.

            Console.WriteLine("Input a decimal number:");
            int number = int.Parse(Console.ReadLine());
            int result = number;
            List<int> list = new List<int>();

            while (result != 0)
            {
                int remainder = result % 16;
                //     Console.WriteLine(remainder);
                list.Add(remainder);
                result = result / 16;
                remainder = result;

            }
            list.TrimExcess();
            list.Reverse();
            Console.Write("Hexadecimal representation: \n0x");
            foreach (int item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
