using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart2
{
    class Rectangle : Shape
    {

        public Rectangle(double height, double width)
            //: base(height, width)
         
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
            double surface = this.Height * this.Width;
            return surface;
        }

    }
}
