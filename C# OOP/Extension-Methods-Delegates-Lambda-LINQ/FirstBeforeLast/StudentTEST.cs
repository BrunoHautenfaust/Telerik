using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.*/

namespace FirstBeforeLast
{
    class StudentTEST
    {
        static void Main(string[] args)
        {

            Student[] students = {
                 new Student("Petmez", "Kolev", 18),
                 new Student("Topuz", "Padarov", 25),  
                 new Student("Mastiya", "Nesheva", 23),
                 new Student("Katma", "Gencheva", 26),  
                 new Student("Biftek", "Dimitrov", 22)
                                 };

            // Problem 3. First before last
            var query1 = from student in students
                        where student.FirstName.CompareTo(student.LastName) < 0
                        orderby student.FirstName ascending//, student.LastName descending
                        select student;

            Console.WriteLine("1/ Sorted by first name before last name alphabetically:\n");
            Console.WriteLine(string.Join(Environment.NewLine, query1));
            Console.WriteLine("\n" + new string('=', 20));

            // Problem 4. Age range
            var query2 = from student in students
                         where student.Age >= 18 && student.Age < 24
                         orderby student.FirstName
                         select student;

            Console.WriteLine("2/ Sorted by first name and last name with age (18-24):\n");
            Console.WriteLine(string.Join(Environment.NewLine, query2));
            Console.WriteLine("\n" + new string('=', 20));

            // Problem 5. Order students
            Console.WriteLine("3.1/ Sorted by first name and last name in descending order [lambda]:\n");
            // Lambda:
            var query3 = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine(string.Join(Environment.NewLine, query3));
            Console.WriteLine("\n" + new string('=', 20));
            Console.WriteLine("3.2/ Sorted by first name and last name in descending order [LINQ]:\n");
            // LINQ
            var query4 = from student in students
                         orderby student.FirstName descending
                         select student;
            Console.WriteLine(string.Join(Environment.NewLine, query4));
            Console.WriteLine("\n" + new string('=', 20));


        }
    }
}
