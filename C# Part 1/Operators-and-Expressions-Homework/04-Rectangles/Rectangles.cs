using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates rectangle’s perimeter and area by given width and height.

            Console.WriteLine("Input width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Input height:");
            double height = double.Parse(Console.ReadLine());
           double P = 2*(width + height);
            double S = width * height;
            Console.WriteLine("The Perimeter is "+P);
            Console.WriteLine("The Area is " +S);



        }
    }
}
