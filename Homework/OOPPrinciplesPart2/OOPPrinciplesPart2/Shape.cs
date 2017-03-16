using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart2
{
    public abstract class Shape
    {
        //public Shape(double height, double width)
        //{
        //    this.Height = height;
        //    this.Width = width;
        //}
        protected double Width { get; set; }
        protected double Height { get; set; }
        public abstract double CalculateSurface();
       
    }
}
