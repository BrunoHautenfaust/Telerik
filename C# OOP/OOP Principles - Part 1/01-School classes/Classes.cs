
namespace _01_School_classes
{
    class Classes : School
    {
        private Students student;
        private Teachers teacher;

        public Students Student { get; set; }
        public Teachers Teacher { get; set; }

        public Classes()
        {

        }
        public Classes(Students student, Teachers teacher)
        {
            this.Student = student;
            this.Teacher = teacher;
        }
    }
}
