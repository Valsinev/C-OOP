using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[] {
            new Tomcat("Pesho", 2),
            new Kitten("Djidji", 4),
            new Dog("Grum", 3, Sex.Male),
            new Frog("Unufri", 5, Sex.Male)
        };
            Cat[] cats = new Cat[]
        {
            new Kitten("Maia", 2),
            new Tomcat("Riko", 6)
        };
            Console.WriteLine(animals.Average(a => a.Age));
            Console.WriteLine(cats.Average(c => c.Age));
        }
    }
}
