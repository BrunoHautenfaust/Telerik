
using System;
using System.Linq;
using System.Text;
namespace Point3D
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D ParsePoint(string text)
        {
            int OpenPar = text.IndexOf('(');
            double[] pointCoord = text.Substring(OpenPar + 1, text.Length - OpenPar - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            return new Point3D() { X = pointCoord[0], Y = pointCoord[1], Z = pointCoord[2]};
        }

        public override string ToString()
        {
            StringBuilder points = new StringBuilder();
            points.AppendFormat("point coordinates({0}, {1}, {2})", X, Y, Z);
            return points.ToString();
        }
    }
}
