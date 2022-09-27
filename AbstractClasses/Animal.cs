using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Animal
    {
        private string Name { get; set; }

        public void setName(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public abstract void Eat();

    }
}
