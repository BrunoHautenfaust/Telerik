
using System;
using System.IO;
namespace Point3D
{
    public static class PathStorage
    {
       public static Path path = new Path();

       
          // Save path
        public static void SavePath(Path pointList, string pathAddress)
        {
            using (StreamWriter writer = new StreamWriter(pathAddress)) 
            {
                foreach (Point3D point in pointList)
                {
                    writer.WriteLine(point);    // string line = point.ToString();
                }
            }
            Console.WriteLine("Points saved successfully to an external file!");
        }

        // Load path
        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            var reader = new StreamReader(filePath);         // @"..\..\output.txt"
            using (reader)                           // Another way to write and use Streams  
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    var point = Point3D.ParsePoint(line);
                    path.AddPoint(point);
                    line = reader.ReadLine();               // Interesting idea:
                                                            //double x = 0;
                                                            //double y = 0;
                                                            //double z = 0;

                                                            //string[] readPoints = line\
                                                            //.Split(new char[] { ' ' },
                                                            //StringSplitOptions.RemoveEmptyEntries);

                                                            //x = double.Parse(readPoints[0]);
                                                            //y = double.Parse(readPoints[1]);
                                                            //z = double.Parse(readPoints[2]);

                                                            //Point3D newPoint = new Point3D(x, y, z);

                                                            //path.AddPoint(newPoint);

                                                            //line = reader.ReadLine();
                }
            }
            return path;
        }

    }
}
