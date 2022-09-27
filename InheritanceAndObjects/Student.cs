using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndObjects
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {

        }

        public void study()
        {
            Console.WriteLine("I'm studying.");
        }
    }
}
