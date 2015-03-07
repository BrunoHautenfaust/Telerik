using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Tom";
            string lastName = "Stevenson";
            byte age = 34;
            char gender = 'm';
            ulong PID = 8306112507;
            ulong UID = 2756000012342569999;

            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge = {2}\nGender = {3}\nPID = {4}\nUID = {5}",
            firstName, lastName, age, gender, PID, UID);
        }
    }
}
