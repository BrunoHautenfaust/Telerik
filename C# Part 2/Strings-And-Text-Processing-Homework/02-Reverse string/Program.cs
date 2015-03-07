using System;

    class Program
    {
        /*
          Write a program that reads a string, reverses it and prints the result at the console.
         Example:

         input	output
         sample	elpmas
          */

        static void Main(string[] args)
        {
            Console.WriteLine("Input a string:");
            string text = Console.ReadLine();
           string reversed = ReverseString(text);
            Console.WriteLine(reversed);
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
