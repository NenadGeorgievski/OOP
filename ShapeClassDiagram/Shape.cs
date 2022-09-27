using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClassDiagram
{
    public abstract class Shape
    {
        protected Location Location { get; set; }

        public override string ToString()
        {
            return $"x : {Location.x} y : {Location.y}";
        }

        public Shape(double x, double y)
        {
            Location = new Location();
            Location.x = x;
            Location.y = y;


        }

        public abstract double Area();



        public abstract double Perimeter();
        
    }
}
