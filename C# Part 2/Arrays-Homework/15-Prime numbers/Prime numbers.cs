using System;

class Program
{
    static void Main(string[] args)
        {
            // Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

            bool[] arr = new bool[10000000];

            for (int i = 2; i < Math.Sqrt(arr.Length); i++)
            {
              if (arr[i] == false)
              {
                  for (int j = i*i; j < arr.Length; j+=i)
                  {
                      arr[j] = true;
                  }
              }
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] != true)
                {
                Console.WriteLine(i+"-> prime");
            }
                }

        }
}

