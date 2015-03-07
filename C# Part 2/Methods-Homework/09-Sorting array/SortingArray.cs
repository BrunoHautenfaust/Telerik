using System;

    class SortingArray
    {
        static void Main(string[] args)
        {
            /*Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/

           //   int[] arr = { 1, 4, 3, 6, 3, 1, 3, 1, 8 };

              int index = 0;

              Console.WriteLine("Input array length:");
              int arrLength = int.Parse(Console.ReadLine());

              int[] arr = new int[arrLength];

              // fill array
              for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write("arr[{0}] = ", i);
                  arr[i] = int.Parse(Console.ReadLine());
              }
              do
              {
                  Console.WriteLine("Input index number:");
                  index = int.Parse(Console.ReadLine());
              } while (index < 0 || index > arr.Length - 1);


              int result = ReturnMaxElementWithStartingIndex(arr, index);
              Console.WriteLine("Max element from index({0}) is {1}", index, result);

        }

        public static int ReturnMaxElementWithStartingIndex(int[] arr, int index)
        {
            int max = arr[index];
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[index] < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }

