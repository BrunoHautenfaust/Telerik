namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    class Program
    {
        static void Main(string[] args) // BGCoder Score 100/100
        {
            string input = Console.ReadLine(); // "1 6 8 10 3 1 1";
            long[] arr = input
                .Split(' ').Select(n => Convert.ToInt64(n))
                .ToArray();


            var list = new List<long>();
            int startPosition = 1;
            int jump = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (startPosition >= arr.Length)
                {
                    break;
                }

                int previousPosition = startPosition - 1;
                long diff = Math.Abs(arr[startPosition] - arr[previousPosition]);


                if (diff % 2 == 0)
                {
                    list.Add(diff);
                    jump = 2;
                    startPosition += jump;
                }
                else if (diff % 2 != 0)
                {
                    list.Add(diff);
                    jump = 1;
                    startPosition += jump;
                }
            }

            BigInteger sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    sum += list[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
