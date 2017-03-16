using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string Name, int Age,Sex sex)
            : base(Name, Age,sex)
        {
        }
        public override string Speak()
        {
            return "meow";
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Sex;
        }
    }
}
