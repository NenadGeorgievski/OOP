using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClassDiagram
{
    public class Rectangle : Shape
    {
        protected double side1, side2;

        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public void setSides(double a, double b)
        {
            side1 = a;
            side2 = b;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
    }
}
