using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Student_class
{
    class StudentTEST
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Dragan", "Petkov", "Ivanov", 111111);
            Student student2 = new Student("Ivan", "Georgiev", "Stoinov", 222222);

           // Console.WriteLine("Equality check: " + student1.Equals(student2));
            Console.WriteLine("Equality check: " + (student1 == student2));
            Console.WriteLine("HashCodes: {0} and {1}", student1.GetHashCode(), student2.GetHashCode());
            Console.WriteLine(student1);

            Student student3 = new Student("Todor", "Stankov", "Todorov", 333333, "ul. Bezimenna 54",
                0888333333, "toshich@mail.bg", 2,
                Enums.Specialties.Psychology, Enums.Universities.SU, Enums.Faculties.Philosophy);

            Console.WriteLine(student3);

            // Clone
            var studentClone = student3.Clone();
            Console.WriteLine(studentClone);

            // Compare
            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
