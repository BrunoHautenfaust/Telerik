
namespace _01_School_classes
{
    class People : Classes
    {
        private Teachers teacher;
        private Students student;

        public Teachers Teacher { get; set; }
        public Students Student { get; set; }

        public People()
        {

        }

        public People(Teachers teacher)
        {
            this.Teacher = teacher;
        }

        public People(Students student)
        {
            this.Student = student;
        }
    }
}
