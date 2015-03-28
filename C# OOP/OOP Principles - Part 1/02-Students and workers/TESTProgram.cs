using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Students_and_workers
{
    class TESTProgram
    {
        static void Main(string[] args)
        {
            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Peshev", 5),
                new Student("Ivan", "Ivanov", 6),
                new Student("Georgi", "Georgiev", 3),
                new Student("Stamat", "Stamatov", 4.5),
                new Student("Fidanka", "Gancheva", 3.5),
                new Student("Stefan", "Stefanov", 2),
                new Student("Maria", "Kuneva", 6),
                new Student("Aleksandar", "Aleksandrov", 6),
                new Student("Martina", "Mancheva", 5.5),
                new Student("Dimitar", "Dimitrov", 5)
            };

            var sortedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));
            Console.WriteLine(new string('=', 50));

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Silviya", "Staneva", 80m, 8),
                new Worker("Dragan", "Draganov", 100m, 8),
                new Worker("Stanimir", "Stanimirov", 80m, 8),
                new Worker("Asen", "Filchev", 150m, 8),
                new Worker("Kalina", "Vankova", 80m, 8),
                new Worker("Evgeni", "Nachev", 120m, 8),
                new Worker("Vencislav", "Yanev", 80m, 8),
                new Worker("Vanya", "Ganeva", 300m, 8),
                new Worker("Svetoslav", "Grigovor", 60m, 8),
                new Worker("Krasimir", "Nikolov", 80m, 8),
            };

            var sortedWorkers = from worker in workers
                                orderby worker.WeekSalary
                                select worker;
            Console.WriteLine(string.Join(Environment.NewLine, sortedWorkers));
            Console.WriteLine(new string('=', 50));

            // Merge the lists and sort them by first name and last name.
            var mergedList = students.Cast<Human>().
                Concat(workers.Cast<Human>()).
                ToList().
                OrderBy(x => x.FirstName).
                ThenBy(x => x.LastName);

            Console.WriteLine(string.Join(Environment.NewLine, mergedList));
                             
        }
    }
}
