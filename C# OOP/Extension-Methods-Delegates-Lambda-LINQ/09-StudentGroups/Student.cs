
using System;
using System.Collections.Generic;
using System.Text;
namespace _09_StudentGroups
{
    // FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public int GroupNumber { get; set; }
        public Group Group { get; set; }
      

        public Student(string firstName, string lastName, int fn, string tel, string email, int groupNumber, Group groupa, params double[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Group = groupa;
            this.Marks = new List<double>(marks);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("First Name: {0}\n", this.FirstName)
                .AppendFormat("Last Name: {0}\n", this.LastName)
                .AppendFormat("Fac. Number: {0}\n", this.FN)
                .AppendFormat("Tel.: {0}\n", this.Tel)
                .AppendFormat("Email: {0}\n", this.Email)
                .AppendFormat("Group Number: {0}\n", this.GroupNumber)
                .Append(this.Group)
                .AppendFormat("Marks: {0}\n", string.Join(", ", this.Marks));
            return sb.ToString();
        }
       
    }
}
