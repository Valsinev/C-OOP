using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart2
{
    class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and heigth should be bigger than zero!");
            }
            else
            {
                this.Height = height;
                this.Width = width;
            }
        }
        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width / 2.0;
            return surface;
        }
    }
}
