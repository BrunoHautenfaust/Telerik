
namespace _01_Shapes
{
    class Triangle : Shape
    {
     
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }

        public override string ToString()
        {
            return string.Format("Triangle");
        }
    }
}
