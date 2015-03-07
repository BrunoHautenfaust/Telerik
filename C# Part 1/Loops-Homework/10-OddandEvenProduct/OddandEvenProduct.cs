using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OddandEvenProduct
{
    class OddandEvenProduct
    {
        static void Main(string[] args)
        {
            /*You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

            int evenProduct = 1;
            int oddProduct = 1;
         
            Console.WriteLine("Write numbers separated by a space:");
            string text = Console.ReadLine();
            string[] textArr = text.Split(' ');
            int[] arr = new int[textArr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(textArr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2 == 0)
                {
                    evenProduct *= arr[i];
                }
                    
                else
                {
                    oddProduct *= arr[i];
                }
                     
            }
         //  Console.WriteLine(evenProduct);
         //  Console.WriteLine(oddProduct);
            
           if (evenProduct == oddProduct)
           {
               Console.WriteLine("yes");
           }
           else
           {
               Console.WriteLine("no");
           }
             
        }
    }
}
