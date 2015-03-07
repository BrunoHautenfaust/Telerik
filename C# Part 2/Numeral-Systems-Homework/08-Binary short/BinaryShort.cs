using System;
using System.Collections.Generic;

    class BinaryShort
    {
        static void Main(string[] args)
        {
     // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

            Console.WriteLine("Input a 16-bit signed integer number(short):");
            short number = Int16.Parse(Console.ReadLine());
          //  short NumtoDec = number;
            NumtoBin(number);

            Console.WriteLine("The binary representation is: {0}", );
        }

        static short NumtoBin(short num)
        {
            num = Int16.Parse(Console.ReadLine());
            int result = num;
            List<Int16> list = new List<Int16>();

            while (result != 0)
            {
                short remainder = result % 2;
                //     Console.WriteLine(remainder);
                list.Add(remainder);
                result = result / 2;
                remainder = result;


            }
            list.TrimExcess();
            list.Reverse();
            Console.WriteLine("Binary representation: ");
            foreach (int item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

