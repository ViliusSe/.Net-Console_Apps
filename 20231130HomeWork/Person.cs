﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork
{
    internal class Person
    {
        
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age; 
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }
}
