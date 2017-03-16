using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses4
{
    class Teacher
    {
        private List<Discipline> subject;
        private string name;

        //constructor
        public Teacher(string teacherName)
        {
            this.name = teacherName;
            this.Subject = new List<Discipline>();
        }
        //properties
        public List<Discipline> Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }
        //methods
        public void AddDiscipline(Discipline disc)
        {
            this.Subject.Add(disc);
        }
        public void RemoveDiscipline(Discipline disc)
        {
            foreach (var item in this.Subject)
            {
                if (item == disc)
                {
                    this.Subject.Remove(disc);
                }
            }
        }
    }
}
