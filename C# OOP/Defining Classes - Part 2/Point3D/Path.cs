
using System.Collections;
using System.Collections.Generic;
namespace Point3D
{
   public class Path : IEnumerable<Point3D>       
    {
       private List<Point3D> pointsList;

       // Property
       public List<Point3D> PointsList
       {
           get
           {
               return this.pointsList;
           }
       }

       // Constructor
       public Path()
       {
           pointsList = new List<Point3D>();
       }

       public void AddPoint(Point3D point)
       {
           pointsList.Add(point);
       }

       public IEnumerator<Point3D> GetEnumerator()
       {
           return this.pointsList.GetEnumerator();
       }
       IEnumerator IEnumerable.GetEnumerator() // Isn't "public IEnumerator<Point3D> GetEnumerator()" enough!? What's this for? 
       {
           return GetEnumerator();
       }


   }
}
