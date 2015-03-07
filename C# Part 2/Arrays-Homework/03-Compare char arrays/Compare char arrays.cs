using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that compares two char arrays lexicographically (letter by letter).

            Console.WriteLine("Input arr1 length:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input arr2 length:");
            int n2 = int.Parse(Console.ReadLine());

            char[] arr1 = new char[n1];
            char[] arr2 = new char[n2];

            // Fill arr1
            for (int i = 0; i < n1; i++)
            {
                Console.Write("arr1[{0}]= ", i);
                arr1[i] = char.Parse(Console.ReadLine());
            }
            // Fill arr2
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr2[{0}]= ", i);
                arr2[i] = char.Parse(Console.ReadLine());
            }

            // Compare arr1 and arr2 lengths
            if (arr1.Length == arr2.Length)
            {
                // Compare arr1 & arr2 elements
                for (int i = 0, j = 0; i < arr1.Length; i++, j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i] + " = " + arr2[j]);
                    }
                    else
                    {
                        Console.WriteLine(arr1[i] + " != " + arr2[j]);
                        Console.WriteLine("Elements NOT equal.\nArrays are NOT equal!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Arrays are NOT equal!");
            }

        }
    }

