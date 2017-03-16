

namespace DefineClasses4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class SchoolClass
    {
        private static List<Teacher> teachers;
        private string textIdentity;
        //constructor
        public SchoolClass(string name)
        {
            this.textIdentity = name;
        }
        //property
        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                teachers = value;
            }
        }
        //methods
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public IList<Teacher> RemoveTeacher(Teacher teacher)
        {
            foreach (var item in teachers)
            {
                if (item == teacher)
                {
                    this.Teachers.Remove(teacher); 
                }   
            }
            return this.Teachers;
        }

    }
}
