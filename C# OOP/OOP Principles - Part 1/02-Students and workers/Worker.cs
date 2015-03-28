
namespace _02_Students_and_workers
{
    class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal MoneyPerHour(decimal weekSalary, int workHoursPerDay)  // decimal weekSalary, int workHoursPerDay
        {
            decimal dailySalary = WeekSalary / 5;
            decimal salaryPerHour = dailySalary / WorkHoursPerDay;
            return salaryPerHour;
        }
      
        public override string ToString()
        {
            return string.Format("First Name: {0}\tLast Name: {1}\tWeek Salary: {2} | Work H per D: {3} | $perH: {4}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay,
                this.MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }
    }
}
