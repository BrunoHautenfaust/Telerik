﻿namespace _3_RefactorLoop
{
    using System;
    public static class Loop
    {
        public static void FindValue(int value)
        {
            int expectedValue = value;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found.");
                    break;
                }
                if (i == array.Length - 1)
                {
                    Console.WriteLine("Value not Found.");
                }

            }
        }

    }
}
