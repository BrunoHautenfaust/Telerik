namespace School.Data.Migrations
{
    using School.Model;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<School.Data.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "School.Data.SchoolDbContext";
        }

        protected override void Seed(SchoolDbContext context)
        {
            context.Students.AddOrUpdate(new Student
                {
                    Name = "Seeded Student"
                });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /*
             * Copied from Package Manager Console:
                Detected database created with a database initializer.
                Scaffolded migration '201510211425458_InitialCreate' corresponding to existing database.
                To use an automatic migration instead, delete the Migrations folder and re-run Enable-Migrations
                specifying the -EnableAutomaticMigrations parameter.
            */
        }
    }
}
