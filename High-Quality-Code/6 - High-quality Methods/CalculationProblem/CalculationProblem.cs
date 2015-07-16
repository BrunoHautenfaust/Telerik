namespace Task1
{
    ﻿using System;
    using System.Text;
    using System.Linq;

    class Program
    {
        static void Main()  // BGCoder Score 20/100
        {   
            string input = Console.ReadLine();
            input = String.Join("", input.Where(c => !char.IsWhiteSpace(c)));
            StringBuilder strangeNumber = new StringBuilder();
            string[] CatAlphabet = new string[23] { "a", "b", "c", "d", "e", "f", "g",
                                                    "h", "i", "j", "k", "l", "m", "n", "o",
                                                    "p", "q", "r", "s", "t", "u", "v", "w" };
            ulong result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                strangeNumber.Append(input[i]);
                for (int j = 0; j < CatAlphabet.Length; j++)
                {
                    if (strangeNumber.ToString() == CatAlphabet[j])
                    {
                        result *= 23;
                        result += (ulong)j;
                        strangeNumber.Clear();
                    }
                }
            }
            Console.WriteLine("{0} = {1}", input, result);
        }
    }
}