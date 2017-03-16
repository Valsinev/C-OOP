
using System;
using System.Linq;
using System.Collections.Generic;
namespace OOPPrinciplesPart2
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
        {
            new Triangle(3, 5),
            new Rectangle(4.5, 4),
            new Square(4),
        };
            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}
