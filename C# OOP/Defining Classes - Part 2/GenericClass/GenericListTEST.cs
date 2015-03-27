using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericListTEST
    {
        static void Main(string[] args)
        {
            var intList = new GenericList<int>(5);
            intList.AddElement(5);
            intList.AddElement(10);
            intList.AddElement(20);
            intList.AddElement(30);
            intList.AddElement(40);
            intList.AddElement(50);

            intList.RemoveElementByIndex(1);

            intList.InsertAtPosition(1, 346);

            Console.WriteLine(intList);

            Console.WriteLine("Min: "+ intList.Min());
            Console.WriteLine("Max: "+ intList.Max());

            intList.Clear();
            Console.WriteLine(intList);

        }
    }
}
