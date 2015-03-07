using System;

    class Program
    {
        static void Main(string[] args)    
        {
            // Write a program that finds in given array of integers a sequence of given sum S (if present).

            Console.WriteLine("Input arr length:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Fill array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input desired sum to look for:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == number)
                    {
                        Console.Write("Sequence is: ");
                        for (int a = i; a <= j; a++)
                        {
                            Console.Write(a != j ? arr[a] + ", " : arr[a] + "");         
                        }
                        Console.WriteLine();
                      //  Console.WriteLine("\nSum: " + sum);
                    }
                 
                }
                sum = 0;
            }

        }
    }

