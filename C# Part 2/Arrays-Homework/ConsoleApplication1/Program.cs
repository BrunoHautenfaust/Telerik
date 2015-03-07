using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the sequence of maximal sum in given array.   // XXXXXXX

        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        string text = "";
        int savedSum = 0;
        string SavedText = "";
        int negCounter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (sum + arr[i] > sum)
            {
                sum += arr[i];
                text += arr[i] + ", ";
                negCounter = 0;
            }
            else
            {
                negCounter++;
                if (negCounter >= 2)
                {
                    sum = arr[i];
                    text = arr[i] + ", ";
                    continue;
                }

                savedSum = sum;
                SavedText = text;
                sum = arr[i];
                text = arr[i] + ", ";
            }
        }

        if (savedSum > sum && text.Length > SavedText.Length)
        {
            Console.WriteLine(sum);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine(savedSum);
            Console.WriteLine(SavedText);
        }

    }
}


