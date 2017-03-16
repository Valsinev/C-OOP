
namespace AnimalHierarchy
{
    using System;
    public class Dog : Animal
    {
        
        public Dog(string Name, int Age,Sex sex)
            : base(Name, Age,sex)
        {
        }
        
        public override string Speak()
        {
            return "woof-woof";
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.Sex;
        }
    }   
}


