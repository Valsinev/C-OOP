
namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;
        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.StringValidator(value, "Name cannot be null or empty !");
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
           //if (course == null)
           //{
           //    throw new NullReferenceException();
           //}
            this.courses.Add(course);
        }
       public override string ToString()
       {
       
           var output = new StringBuilder();
           var coursesName = this.courses.Select(c => c.Name); 
           output.AppendFormat("Teacher: Name={0}", this.Name);
           if (this.courses.Count > 0)
           {
               output.AppendFormat("; Courses=[{0}];", string.Join(", ", coursesName)); 
           }
           return output.ToString().Trim();
       }
    }
}
