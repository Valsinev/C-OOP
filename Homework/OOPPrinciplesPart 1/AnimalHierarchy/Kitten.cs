using System;


namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
         public Kitten(string Name,int Age)
            :base(Name,Age,Sex.Female)
        {
        }
         public override string Speak()
         {
             return base.Speak();
         }
         public override string ToString()
         {
             return base.ToString() + " " + this.Sex;
         }
    }
}
