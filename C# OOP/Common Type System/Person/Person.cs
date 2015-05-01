
namespace Person
{
    public class Person
    {
        private string name;
        private int? age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0}\tAge: {1}", this.Name, "not specified");
            }
            return string.Format("Name: {0}\tAge: {1}", this.Name, this.Age);
        }
        /*Create a class Person with two fields – name and age. Age can be left unspecified
         * (may contain null value. Override ToString() to display the information of a person and
         * if age is not specified – to say so.
Write a program to test this functionality.*/
    }
}
