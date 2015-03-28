using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Students_and_workers
{
    class Student : Human
    {
        private double grade;

        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\tLast Name: {1}\tGrade: {2}", this.FirstName, this.LastName, this.Grade);
        }

    }
}
