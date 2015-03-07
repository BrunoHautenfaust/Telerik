using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            /*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.*/

            int n = 0;
            Console.WriteLine("Input a number:");
               n = int.Parse(Console.ReadLine());

               int[] arr = new int[n];
               for (int i = 0; i < arr.Length; i++)      
               {
                   Console.WriteLine("Input number {0}:", i+1);
                   arr[i] = int.Parse(Console.ReadLine());
               }

            int min = 0;
            int max = 0;
            double sum = 0;
         
            Array.Sort(arr);
            min = arr[0];
            max = arr[arr.Length-1];

            foreach (int i in arr)
            {
                sum += i;
            }
            double avg = sum / arr.Length;
                
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
               
        }
                
    }
