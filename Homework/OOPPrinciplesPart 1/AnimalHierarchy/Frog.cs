using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal 
    {
        public Frog(string Name, int Age,Sex sex)
            : base(Name, Age,sex)
        {
        }
        public override string Speak()
        {
            return "riddit-riddit";
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Sex;
        }

    }
}
