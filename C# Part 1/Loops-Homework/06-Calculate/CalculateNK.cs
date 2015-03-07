using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Calculate
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 Use only one loop.*/

            int n, k = 0;
            int factN = 1;
            int factK = 1;
            int counterN = 1;
            int counterK = 1;

            do
            {
                Console.WriteLine("Input n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Input k:");
                k = int.Parse(Console.ReadLine());
            } while (1 > k || k > n || n > 100);

        //    for (int i = 1; i <= n; i++)
            while (counterN <= n)
            {
                factN *= counterN;
                counterN++;

               
            }
            while (counterK <= k)
            {
                factK *= counterK;
                counterK++;
            }
           
            Console.WriteLine(factN / factK);
        
        }
    }
}
