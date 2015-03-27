using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StudentGroups
{
    class StudentTEST
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Petmez", "Kolev", 123406, "056/11-11-11", "petmez@abv.bg", 1, new Group(222, "Biology"),
                    3.5, 4, 6),
                new Student("Topuz", "Padarov", 123306, "02/22-22-22", "topuz@gmail.com", 3, new Group(223, "Biology"),
                    3, 2, 2),
                new Student("Mastiya", "Nesheva", 153405, "052/33-33-33", "mastiya@yahoo.com", 3,new Group(222, "Informatics"),
                    4, 4.5, 5),
                new Student("Katma", "Gencheva", 123805, "056/44-44-44", "katma@abv.bg", 2, new Group(221, "Mathematics"),
                    4, 5.5, 6),
                new Student("Biftek", "Dimitrov", 163405, "02/55-55-55", "biftek@yahoo.com", 1, new Group(221, "Mathematics"),
                    6, 5.5, 5)
            };

            // Problem 9. Select only the students from group number 2. Use LINQ query. Order the students by FirstName.
            Console.WriteLine(new string('=', 20) + "Problem 9" + new string('=', 20));
            var sortedStudents = from student in students
                                 where student.GroupNumber == 2
                                 orderby student.FirstName
                                 select student;

            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));

            // Problem 10. Implement the previous using the same query expressed with extension methods.
            Console.WriteLine(new string('=', 20) + "Problem 10" + new string('=', 20));

             var sortedStudents2 = sortedStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents2));

            // Problem 11. Extract all students that have email in abv.bg. Use string methods and LINQ.
            Console.WriteLine(new string('=', 20) + "Problem 11" + new string('=', 20));

            var sortedStudents3 = from student in students
                                  where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                                  select student;

            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents3));
            // Problem 12. Extract all students with phones in Sofia. Use LINQ.
            Console.WriteLine(new string('=', 20) + "Problem 12" + new string('=', 20));

            var sortedStudents4 = from student in students
                                  where student.Tel.Substring(0, 2) == "02"
                                  select student;

             Console.WriteLine(string.Join(Environment.NewLine, sortedStudents4));

           // Problem 13. Extract all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            Console.WriteLine(new string('=', 20) + "Problem 13" + new string('=', 20));

            var sortedStudents5 = from student in students
                                  where student.Marks.Contains(6)
    /*select new!?*/         select new { FullName = student.FirstName + " " + student.LastName,
                                               Marks = string.Join(", ", student.Marks) };
                                  
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents5));
            Console.WriteLine();

            // Problem 14. Extract students with two marks "2". Use extension methods.
            Console.WriteLine(new string('=', 20) + "Problem 14" + new string('=', 20));

            var sortedStudents6 = students.Where(x => x.Marks.FindAll(m => m == 2).Count == 2);
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents6));

            // Problem 15. Extract all Marks of the students that enrolled in 2006.         
            // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
             Console.WriteLine(new string('=', 20) + "Problem 15" + new string('=', 20));

             var extractedMarks = students.Where(f => f.FN.ToString().Substring(f.FN.ToString().Length - 2) == "06").
                 Select(m => m.FirstName +" "+ m.LastName + "'s marks: "+ string.Join(", ", m.Marks));
             Console.WriteLine(string.Join(Environment.NewLine, extractedMarks));

            // Problem 16. Extract all students from "Mathematics" department. Use the Join operator.  
             Console.WriteLine(new string('=', 20) + "Problem 16" + new string('=', 20));
             var mathStudents = from student in students
                                where student.Group.DepartmentName == "Mathematics"
                                select student;
             Console.WriteLine(string.Join(Environment.NewLine, mathStudents));

            // Problem 18. Extract all students grouped by GroupNumber. Use LINQ.
             Console.WriteLine(new string('=', 20) + "Problem 18" + new string('=', 20));
            var extractedByDepGroupNumber1 = from student in students
                                            orderby student.Group.GroupNumber
                                            select new
                                            {
                                                FullName = student.FirstName + " " + student.LastName,
                                                DepGroupNumber = string.Join(", ", student.Group.GroupNumber)
                                            };
             Console.WriteLine(string.Join(Environment.NewLine, extractedByDepGroupNumber1));

            // Problem 19. Grouped by GroupName extensions. Use extension methods.
             Console.WriteLine(new string('=', 20) + "Problem 19" + new string('=', 20));

             var extractedByDepGroupNumber2 = students.OrderBy(x => x.Group.GroupNumber)
                 .Select(x => new { x.FirstName, x.LastName, x.Group.GroupNumber });

             Console.WriteLine(string.Join(Environment.NewLine, extractedByDepGroupNumber2));
        }
    }
}
