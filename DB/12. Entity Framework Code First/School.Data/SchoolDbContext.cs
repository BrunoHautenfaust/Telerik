namespace School.Data
{
    using School.Model;
    using System.Data.Entity;

    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            :base("SchoolDatabase")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Homework> Homework { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<StudentsInCourses> StudentsInCourses { get; set; }

        
    }
}
