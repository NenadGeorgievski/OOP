using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ShapeClassDiagram
{
    public class Circle : Shape
    {
        protected double radius;
        private double pi = 3.14;

        public Circle(double x, double y) : base(x, y)
        {
        }

        public void setRadius(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return pi * Math.Pow(radius, 2);  
        }

        public override double Perimeter()
        {
            return 2 * pi * radius;
        }
    }
}
