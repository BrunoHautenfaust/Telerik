using System;

class Program
{
    static void Main(string[] args)
    {
        /*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using
          the method Array.BinarySearch() finds the largest number in the array which is ≤ K.*/

        /*
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
         * */

        int[] arr = { 0, 5, 6, 2, 3, 10 };
        int K = 1;
        Array.Sort(arr);
        // print array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine();
        // Largest number smaller or equal to K:
        int index = Array.BinarySearch(arr, K);
      
        while (Array.BinarySearch(arr, K) < 0)
        {
            K--;
        }

        Console.WriteLine("Largest number in the array which is less or equal to K is " + K);
       
    }
}
