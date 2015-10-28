namespace School.ConsoleClient
{
    using System;
    using System.Linq;
    using School.Data;
    using School.Model;
    using System.Data.Entity;
    using School.Data.Migrations;

    public class Startup            
    {
        // To make the program run - go to App.config for School.ConsoleClient and change Data Source to your server name
        // (that's the string you use to connect to MS SQL Server Management Studio)

        // Rebuild the Solution to restore the Package(s)
        public static void Main(string[] args)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<SchoolDbContext, Configuration>());

            var db = new SchoolDbContext();

            var student = new Student()
            {
                Name = "Ivan",
                Number = 555
            };

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine("The number of students in the database is: " + db.Students.Count());
        }
    }
}
