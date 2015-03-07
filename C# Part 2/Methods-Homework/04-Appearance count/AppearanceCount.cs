using System;

namespace Some
{
    public class AppearanceCount        // Triabva da e public, za da varzhe testa
    {
        static void Main(string[] args)
        {
            /*Write a method that counts how many times given number appears in given array.
            Write a test program to check if the method is working correctly.*/
            //  Testa ne se poluchava

            int[] arr = { 1, 4, 3, 6, 3, 1, 3, 1, 8 };

            Console.WriteLine("Input a number to search for:");
            int n = int.Parse(Console.ReadLine());

            int count = CountNum(arr, n);
            Console.WriteLine("{0} appears {1} time(s) in the array.", n, count);



        }

        public static int CountNum(int[] someArray, int number)
        {
            int counter = 0;
            for (int i = 0; i < someArray.Length; i++)
            {
                if (someArray[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}