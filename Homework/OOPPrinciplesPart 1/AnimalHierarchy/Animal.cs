using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        public Sex Sex { get; set; }

        public Animal(string Name,int Age,Sex sex)
        {
            this.name = Name;
            this.age = Age;
            this.Sex = sex;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public abstract string Speak();
       public override string ToString()
       {
           return this.name + "/ " + this.age;
       }
    }
}
