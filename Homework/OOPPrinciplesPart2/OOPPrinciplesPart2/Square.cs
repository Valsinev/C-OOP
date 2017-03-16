using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart2
{
    public class Square : Shape
    {
        public Square(double height)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and heigth should be bigger than zero!");
            }
            else
            {
                this.Height = height;
                this.Width = height;
            }
        }
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;  
        }
    }
}
