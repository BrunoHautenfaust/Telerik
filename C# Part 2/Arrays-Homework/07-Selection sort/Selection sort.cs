using System;

class Program
{
    static void Main(string[] args)
    {
        /*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
         * move it at the second position, etc.*/

        Console.WriteLine("Input arr length:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        // 1, 2, 3, 4, 5, 6, 8  // , 5, 4, 8, 2

        // Fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Sorting algorithm
        for (int i = 0; i < arr.Length; i++)
        {
            int index = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[index] > arr[j])
                    index = j;

                int smallerNumber = arr[index];
                arr[index] = arr[i];
                arr[i] = smallerNumber;
            }
            Console.WriteLine(arr[i]);
        }
    }
}

