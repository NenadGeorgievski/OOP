﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndObjects
{
    public class Person
    {
        private string Name { get; set; }

        public Person(string name)
        {
            Name = name;    
        }

        public override string ToString()
        {
            return "Hello my name is: " + Name;
        }
    }
}
