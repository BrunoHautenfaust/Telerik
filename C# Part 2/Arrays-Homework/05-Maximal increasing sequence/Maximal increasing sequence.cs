using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the maximal increasing sequence in an array.  // Genius solution!!!

            Console.WriteLine("Input array length:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int number = arr[0];
            string text = "";
            string Secondary = "";

            for (int i = 1; i < arr.Length; i++)
            {
               if (arr[i] - number == 1)
               {
                   text += ", " + arr[i];
               }
               else 
               {
                   if (text.Length > Secondary.Length)
                   {
                       Secondary = text;
                   }
                   text = "" + arr[i];   // !
               }
               number = arr[i];
            }

            // Output:
            if (text.Length > Secondary.Length)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(Secondary);
            }
         
        }
    }

