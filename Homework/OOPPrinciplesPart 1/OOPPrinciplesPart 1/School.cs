
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class School
    {
        private List<Class> classes;
        public School(string name, List<Class> Classes = null)
        {
            this.Name = name;
            this.classes = Classes;//new List<Classes>();
        }
        public string Name { get; private set; }
        // public List<Classes> Class
        // {
        //     get { return }
        // }
        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
    }
}
