using System;

class Program
{
    static void Main(string[] args)
    {
        /*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using
          the method Array.BinarySearch() finds the largest number in the array which is ≤ K.*/

        
        Console.WriteLine("Input N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Input K");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        // fill array:
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("matrix[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        /* Test:
        int[] arr = {0, 5, 6, 2, 3, 10};
        int K =7;
        */

        Array.Sort(arr);
        // print sorted array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+", ");
        }
        Console.WriteLine();

        // Largest number smaller or equal to K:
        int index = Array.BinarySearch(arr, K);
        
         while (index < 0)
        {
            K--;
            index = Array.BinarySearch(arr, K);
        }
  
        Console.WriteLine("Largest number is {0}. It's less or equal to K at position {1}.", K, index);

    }
}
