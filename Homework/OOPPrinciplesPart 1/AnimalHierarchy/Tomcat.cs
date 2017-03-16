
namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
         public Tomcat(string Name,int Age)
            :base(Name,Age,Sex.Male)
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
