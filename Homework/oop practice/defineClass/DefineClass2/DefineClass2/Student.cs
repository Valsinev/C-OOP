
namespace DefineClass2
{
    using System;
    public class Student
    {
        public static int count = 0;

        private string firstName;
        private string lastName;
        private int kourse;
        private string speciality;
        private string phoneNumber;

        public Student(string name, string sirName)
        {
            this.FirstName = name; 
            this.LastName = sirName;
            this.SecondName = null;
            this.School = null;
            this.Email = null;
            this.PhoneNumber = null;
            count++;
        }
        public Student(string name, string sirName, int year, string subject) : 
            this(name, sirName)
        {
            this.kourse = year;
            this.speciality = subject;
        }
      
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 3 )
                {
                    throw new ArgumentException("Name must be longer than 3 symbols!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Last naame must be longer than 5 symbols!");
                }
                this.lastName = value;
            }

        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                //if (value.Length < 11)
                //{
                //    throw new ArgumentException("Phone must contain 10 digits!");
                //}
                this.phoneNumber = value;
                
            }

        }
        public string SecondName { get; set; }
        public string School { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return "First name: " +
                   this.FirstName + "\n" + "Second name: " +
                   this.SecondName + "\n" + "Last name: " +
                   this.LastName + "\n" + "Course: " +
                   this.kourse + "\n" + "Speciality: " +
                   this.speciality + "\n" + "Shchool: " +
                   this.School + "\n" + "Email address: " +
                   this.Email + "\n" + "Phone number: " +
                   this.PhoneNumber;
        }
    }
}
