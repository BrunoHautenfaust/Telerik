
namespace _01_School_classes
{
    class Students : People
    {
        private string name;
        private int classNumber;

        public string Name { get; set; }
        public int ClassNumber { get; set; }

        public Students(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }
    }
}
