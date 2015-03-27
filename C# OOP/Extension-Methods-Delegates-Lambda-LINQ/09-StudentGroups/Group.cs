/*Create a class Group with properties GroupNumber and DepartmentName.
Introduce a property GroupNumber in the Student class.
Extract all students from "Mathematics" department.
Use the Join operator.*/

using System.Text;
namespace _09_StudentGroups
{
    class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.AppendFormat("Dep. Group Number: {0}\n", this.GroupNumber)
               .AppendFormat("Department Name: {0}\n", this.DepartmentName);
           return sb.ToString();
        }
    }
}
