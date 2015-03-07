using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the maximal sequence of equal elements in an array.

        Console.WriteLine("Input array length:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int Primary = arr[0];
        int Pcounter = 1;
        int Secondary = 0;
        int Scounter = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (Primary == arr[i])
            {

                Pcounter++;
            }
            //  else if (Secondary < Primary && Scounter < Pcounter)
            else
            {
                Secondary = Primary;
                Scounter = Pcounter;
                Primary = arr[i];
                Pcounter = 1;
            }
        }
        if (Primary > Secondary && Pcounter > Scounter)
        {
            for (int i = 0; i < Pcounter; i++)
            {
                Console.Write(Primary + ", ");
            }
        }
        else
        {
            for (int i = 0; i < Scounter; i++)
            {
                Console.Write(Secondary + ", ");
            }
        }

    }
}


