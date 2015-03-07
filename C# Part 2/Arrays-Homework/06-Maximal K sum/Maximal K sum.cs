using System;

    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two integer numbers N and K and an array of N elements from the console.
 Find in the array those K elements that have maximal sum.*/

            int N = 0, K = 0;
            do
            {
                Console.WriteLine("Input N:");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Input K:");
                K = int.Parse(Console.ReadLine());
            } while (K > N);

            int[] arr = new int[N];
            int MaxSum = 0;
            string Kelements = "";

            // Fill array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Descending order sort
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            for (int i = 0; i < K; i++)
            {
                MaxSum += arr[i];
                Kelements += arr[i] + ", ";
            }
            Console.WriteLine("MaxSum = "+ MaxSum);
            Console.WriteLine("K elements: "+Kelements);
           
        }
    }

