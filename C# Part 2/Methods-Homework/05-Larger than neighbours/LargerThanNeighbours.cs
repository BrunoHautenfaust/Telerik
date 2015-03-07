using System;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        // Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

      //  int[] arr = { 1, 4, 3, 6, 3, 1, 3, 1, 8 };

        Console.WriteLine("Input array length:");
        int arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        // fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Input a number to search for:");
        int n = int.Parse(Console.ReadLine());

       // Console.WriteLine(  Array.IndexOf(arr, n) );
     string final = LargerThanTwoNeighbours(arr, n);
        Console.WriteLine(final);
    }

    static string LargerThanTwoNeighbours(int[] array1, int number )
    {
        int numberPosition = Array.IndexOf(array1, number);

        int previous = numberPosition - 1;
        int next = numberPosition + 1;

        string result = string.Empty;

        if ( numberPosition == 0 || numberPosition == array1.Length-1 )
        {
            result = "No two neighbours found.";
        }
        else if (number > array1[previous] && number > array1[next])
            {
                result = "The number is larger than its two neighbours.";
            }
        else
        {
            result = "The number is NOT larger than its two neighbours.";
        }
       
        return result;
    }
   
    
}

