using System;

class TriangleSurface
{
    static void Main(string[] args)
    {
        /*Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
        Use System.Math.
         
         Scroll down to the methods to see example values.*/

        Console.WriteLine("Select option");
        Console.WriteLine("Calculate the surface of a triangle by given:");
        Console.WriteLine("1 - Side and an altitude to it;");
        Console.WriteLine("2 - Three sides;");
        Console.WriteLine("3 - Two sides and an angle between them.");

        int option = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (option)
        {
            case 1:
                SideAndAltitude();
                break;
            case 2:
                ThreeSides();
                break;
            case 3:
                TwoSidesAndAngle();

                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }

    private static void SideAndAltitude()
    {
        Console.WriteLine("1 - Side and an altitude to it;");
        Console.Write("Input side:");   // 3
        decimal side = decimal.Parse(Console.ReadLine());
        Console.Write("Input side altutude:");  // 5
        decimal altitude = decimal.Parse(Console.ReadLine());

        decimal A1 = (side * altitude) / 2;  // 7.5
        Console.WriteLine("Area = {0}", A1);
    }

    private static void ThreeSides()
    {
        Console.WriteLine("2 - Three sides;");
        Console.Write("Input sideA:");  // 3
        decimal sideA = decimal.Parse(Console.ReadLine());
        Console.Write("Input sideB:");  // 4
        decimal sideB = decimal.Parse(Console.ReadLine());
        Console.Write("Input sideC:");  // 5
        decimal sideC = decimal.Parse(Console.ReadLine());

        decimal P = (sideA + sideB + sideC) / 2;   // 6
        decimal A2 = (decimal)Math.Sqrt((double)(P * (P - sideA) * (P - sideB) * (P - sideC)));
        Console.WriteLine("Area = {0}", A2);       // 6
    }


    private static void TwoSidesAndAngle()  //
    {
        Console.WriteLine("3 - Two sides and an angle between them.");
        Console.Write("Input side1:");  // 5
        decimal side1 = decimal.Parse(Console.ReadLine());
        Console.Write("Input side2:");  // 6
        decimal side2 = decimal.Parse(Console.ReadLine());
        Console.Write("Input angle between them:"); // 30
        decimal angle = decimal.Parse(Console.ReadLine());
        angle = angle * (decimal)Math.PI / 180.0m;
        decimal A3 = (  (decimal)Math.Sin((double)angle) * side1 * side2) / 2.0m;
        Console.WriteLine("Area = {0}", A3);  // 7.5


    }
}

