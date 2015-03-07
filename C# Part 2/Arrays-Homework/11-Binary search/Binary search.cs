using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

        Console.WriteLine("Input arr length:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Console.WriteLine("Input searched number:");
        int num = int.Parse(Console.ReadLine());

        int minPos = 0;
        int maxPos = arr.Length - 1;
        int midPos = 0;
        bool Found = false;

        while (Found==false)
        {
            midPos = (minPos + maxPos) / 2;
            if (num == arr[midPos])
            {
                Found = true;
            }
            else if (num < arr[midPos])
            {
                maxPos = midPos;
            }
            else if (num > arr[midPos])
            {
                minPos = midPos;
            }
        }
        Console.WriteLine("The searched number {0} is at position {1}", num, midPos);


    }
}

