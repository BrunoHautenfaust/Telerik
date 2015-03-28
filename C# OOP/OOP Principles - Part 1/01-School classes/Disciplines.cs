
namespace _01_School_classes
{
    class Disciplines : Teachers
    {
        //private string name;
        //private int numberOfLectures;
        //private int numberOfExercices;

        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercices { get; set; }

        public Disciplines(string name, int numberOfLectures, int numberOfExercices)
            : base()
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercices = numberOfExercices;
        }
    }
}
