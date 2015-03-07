using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            // First comparison:
           double num1 = 5.3;
           double num2 = 6.01;
           double eps = 0.000001;
           bool compare1 = (Math.Abs(num1 - num2)) < eps;
           Console.WriteLine(compare1);

            // Second comparison:
           double num3 = 5.00000001;
           double num4 = 5.00000003;
           bool compare2 = (Math.Abs(num3 - num4)) < eps;
           Console.WriteLine(compare2);

           // Third comparison:
           double num5 = 5.00000001;
           double num6 = 5.00000003;
           bool compare3 = (Math.Abs(num5 - num6)) < eps;
           Console.WriteLine(compare3);

           // Fourth comparison:
           double num7 = -0.0000007;
           double num8 = 0.00000007;
           bool compare4 = (Math.Abs(num7 - num8)) < eps;
           Console.WriteLine(compare4);

           // Fifth comparison:
           double num9 = -4.999999;
           double num10 = -4.999998;
           bool compare5 = (Math.Abs(num9 - num10)) < eps;
           Console.WriteLine(compare5);

           // Sixth comparison:
           double num11 = 4.999999;
           double num12 = 4.999998;
           bool compare6 = (Math.Abs(num11 - num12)) < eps;
           Console.WriteLine(compare6);
        }
    }
}
