using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the most frequent number in an array.

        Console.WriteLine("Input arr length:");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Fill array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int current = 0;
        int counter = 0;
        int savedCurrent = 0;
        int SavedCounter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            current = arr[i];
            counter = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (current == arr[j])
                {
                    counter++;
                }
                if ((j == arr.Length - 1) && (counter >= SavedCounter))
                {
                    savedCurrent = current;
                    SavedCounter = counter;
                }
            }
        }

        if (counter > SavedCounter)
        {
            Console.WriteLine("{0} ({1} times)", current, counter);
        }
        else
        {
            Console.WriteLine("{0} ({1} times)", savedCurrent, SavedCounter);
        }

    }
}

