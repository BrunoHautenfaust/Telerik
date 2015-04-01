
namespace _01_Shapes
{
    public abstract class Shape
    {
       public double width;
       public double height;

       public double Width { get; set; }
       public double Height { get; set; }

       public abstract double CalculateSurface();
        
    }
}
