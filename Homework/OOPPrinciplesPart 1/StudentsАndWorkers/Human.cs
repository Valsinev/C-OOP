
namespace StudentsАndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human(string FirstName,string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
