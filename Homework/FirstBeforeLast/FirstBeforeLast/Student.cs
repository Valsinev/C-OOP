using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    public class Student
    {
        private string fName;
        private string lName;

        public Student(string firstName, string lastName, int age)
        {
            this.fName = firstName;
            this.lName = lastName;
            this.Age = age;
        }
        public int Age { get; private set; }
        public string FirstName
        {
            get
            {
                return this.fName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lName;
            }
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age;
        }
    }
}
