namespace _06_CloneDB
{
    using System;
    using _01_NorthwindDbContext;

    class Program
    {
        static void Main(string[] args)
        {
            // Create a database called NorthwindTwin with the same structure as Northwind
            // using the features from DbContext.

            // You must change your App.config file in order to generate a clone of Northwind
            // App.config changed:
            //initial catalog=North;    >to>    initial catalog=NorthCLONE; 

            // That's why after the first run, the result will be False
            using (var north = new NorthwindEntities())
            {
                var clone = north.Database.CreateIfNotExists();

                Console.WriteLine("Database clone created : " + clone);
                Console.WriteLine("True = YES \t False = NO");
            }

        }
    }
}
