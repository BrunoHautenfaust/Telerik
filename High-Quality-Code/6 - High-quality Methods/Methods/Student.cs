using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string Info { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = DateTime.Parse(this.BirthDate);
            DateTime secondDate = DateTime.Parse(other.BirthDate);

            return firstDate < secondDate;
        }
    }
}