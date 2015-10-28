namespace School.Model
{
    using System.Collections.Generic;

    public class StudentsInCourses
    {
        // I have the suspicion that this class is wrong

        private ICollection<Student> students;
        private ICollection<Course> courses;

        public int Id { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
