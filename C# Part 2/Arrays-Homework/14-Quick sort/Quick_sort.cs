using System;
using System.Collections.Generic;

    class Quick_sort
    {
        static void Main(string[] args)    
        {
            // Write a program that sorts an array of !integers! using the Quick sort algorithm.

            Console.WriteLine("Input arr length:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Fill array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // TEST:  int[] arr = { 3, 5, 1, 5 ,7 ,2 ,8 ,4, 6 };

            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            List<int> lPivot = new List<int>();
            
            int pivot = arr[arr.Length / 2];

            // Distribute elements
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    l1.Add(arr[i]);
                }
                else if (arr[i] > pivot)
                {
                    l2.Add(arr[i]);
                }
                else // arr[i] == pivot
                {
                    lPivot.Add(arr[i]);
                }
            }

            // Sort lists
            l1.Sort();
            l2.Sort();

                    /* Do I need this?
                    // Trim         
                    l1.TrimExcess();
                    l2.TrimExcess();
                    */

            // Join
            lPivot.AddRange(l2);
            l1.AddRange(lPivot);

            foreach (int item in l1)
            {
                Console.Write(item+", ");
            }
        }
    }

