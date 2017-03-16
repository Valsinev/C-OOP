
namespace StudentsАndWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay; 
        public Worker(string FirstName,string LastName,decimal WeekSalary = 0.0m,int WorkHoursPerDay = 0)
            :base(FirstName,LastName)
        {
            this.weekSalary = WeekSalary;
            this.workHoursPerDay = WorkHoursPerDay;
        }
        public decimal MoneyPerHour()
        {
            decimal money = (this.weekSalary / 7) / workHoursPerDay;
            return money;
        }
        public override string ToString()
        {
            return base.ToString() + ": \n " + "Week Salary: " + this.weekSalary +
                "\n Work hours per day: " + this.workHoursPerDay +
                "\n Money per hour: " + MoneyPerHour();
        }
    }
}
