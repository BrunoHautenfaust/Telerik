
using _01_Student_class.Enums;
using System;
using System.Linq;
using System.Text;
namespace _01_Student_class
{
    class Student : ICloneable, IComparable<Student>
    {
        /*Define a class Student, which contains data about a student
         * – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university,
         * faculty. Use an enumeration for the specialties, universities and faculties.*/

        //private string firstName;
        //private string middleName;
        //private string lastName;
        //private int ssn;
        //private string permanentAddress;
        //private int mobilePhone;
        //private string email;
        //private byte course;
        //private Specialties specialty;
        //private Universities university;
        //private Faculties faculty;
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

       public Student(string firstName, string middleName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public Student(string firstName, string middleName, string LastName, int ssn,
            string permanentAddress, int mobilePhone, string email, byte course,
            Specialties specialty, Universities university, Faculties faculty)
            : this(firstName, middleName, LastName, ssn)
       {
           this.PermanentAddress = permanentAddress;
           this.MobilePhone = mobilePhone;
           this.Email = email;
           this.Course = course;
           this.Specialty = specialty;
           this.University = university;
           this.Faculty = faculty;
       }

        #region Methods, operators
       
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (this.SSN != student.SSN)
            { 
            return false;
            }
            return true;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return Student.Equals(s1, s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(Student.Equals(s1, s2));
        }

        public override int GetHashCode()       // We have to make a XOR(^) between a number and a number
        {
            return this.FirstName.GetHashCode() ^ this.SSN;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(new string('=', 40)+"\n")
                .AppendFormat("First Name: {0}\n", this.FirstName)
                .AppendFormat("Middle Name: {0}\n", this.MiddleName)
                .AppendFormat("Last Name: {0}\n", this.LastName)
                .AppendFormat("SSN: {0}\n", this.SSN)
                .AppendFormat("Permanent Address: {0}\n", this.PermanentAddress)
                .AppendFormat("Mobile Phone: {0}\n", this.MobilePhone)
                .AppendFormat("Email: {0}\n", this.Email)
                .AppendFormat("Course: {0}\n", this.Course)
                .AppendFormat("Faculty: {0}\n", this.Faculty)
                .AppendFormat("Specialty: {0}\n", this.Specialty)
                .AppendFormat("University: {0}\n", this.University)
                .Append(new string('=', 40));
            return sb.ToString();
        }

        #endregion



        public object Clone()
        {     // if the parameters are fields(ex. this.ssn), the copy returns 0/empty values. Is it because the fields are private?
          
            var clone = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN,
                this.PermanentAddress, this.MobilePhone, this.Email, this.Course,
            this.Specialty, this.University, this.Faculty);
            //clone.FirstName = this.FirstName;
            //clone.MiddleName = this.MiddleName;
            //clone.LastName = this.LastName;
            //clone.SSN = this.SSN;
            //clone.PermanentAddress = this.PermanentAddress;
            //clone.MobilePhone = this.MobilePhone;
            //clone.Email = this.Email;
            //clone.Course = this.Course;
            //clone.Specialty = this.Specialty;
            //clone.University = this.University;
            //clone.Faculty = this.Faculty;

            return clone;
        }

        // to compare students by names (as first criteria, in lexicographic order)
        // and by social security number (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                return this.SSN;
            }
            return this.FirstName.CompareTo(other.FirstName);
        }
      
    }
}
