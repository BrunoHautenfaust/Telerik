using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the sequence of maximal sum in given array.   
        
        Console.WriteLine("Input arr length:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        // TEST: int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };     

        int sum = 0;
        int savedSum = 0;
        int startIndex = 0;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (sum <= 0)
            {
                startIndex = i;
                sum = 0;
            }

            sum += arr[i];

            if (sum > savedSum)
            {
                savedSum = sum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write(i != bestEnd ? arr[i]+", " :  arr[i]+"");
        }
        Console.WriteLine();
       
    }
}


