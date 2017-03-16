
namespace StudentsАndWorkers
{
    public class Student : Human
    {
        private string grade;
        public Student(string FirstName, string LastName, string Grade = null)
            : base(FirstName, LastName)
        {
            this.grade = Grade;
        }
        public string Grade
        {
            get
            {
                return this.grade;
            }
        }
        public override string ToString()
        {
            return base.ToString() + ": " + this.Grade;
        }  
    }
}
