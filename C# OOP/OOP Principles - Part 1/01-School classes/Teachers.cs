
namespace _01_School_classes
{
    class Teachers : People
    {
        private string name;
        private Disciplines disciplines;

        public string Name { get; set; }
        public Disciplines Disciplines { get; set; }

        public Teachers()
        {

        }
        public Teachers(string name, Disciplines disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }
    }
}
