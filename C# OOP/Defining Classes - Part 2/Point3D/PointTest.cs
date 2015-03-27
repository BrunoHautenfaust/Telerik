using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class PointTEST
    {
        static void Main(string[] args)
        {
            Point3D staticPoint = new Point3D();
            Point3D firstPoint = new Point3D(1.5, 2, 3.6);
            Point3D secondPoint = new Point3D(4, 2.2, 7);

            Console.WriteLine("<Static> "+staticPoint);
            Console.WriteLine(firstPoint + "\n" + secondPoint);
            double distanceResult = calculateDistance.calculateDistanceMethod(firstPoint, secondPoint);
            Console.WriteLine("distance result: {0:f2}", distanceResult);

            Path pointsList = new Path();
            pointsList.AddPoint(firstPoint);
            pointsList.AddPoint(secondPoint);

            Console.WriteLine();
            string address = @"..\..\savedPath.txt";
            PathStorage.SavePath(pointsList, address);   // Saved to savedPath.txt in the project folder

            Console.WriteLine("\nLoaded points from file:");
            var pathFromFile = PathStorage.LoadPath(address);
            foreach (var item in pathFromFile)
            {
                Console.WriteLine(item);
            }
          
        }
    }
}
