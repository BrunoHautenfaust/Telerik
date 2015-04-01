
namespace _01_Shapes
{
    class Rectangle : Shape
    {
      
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return string.Format("Rectangle");
        }
    }
}
