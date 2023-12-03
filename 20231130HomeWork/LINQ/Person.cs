using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork.LINQ
{
    internal class Person
    {
        public string Name { get; set; }

        public List<Animal> Animals = new List<Animal>();

        //Konstruktorius
        public Person(string name) {
            this.Name = name;
        }
        public void AddAnimal(Animal name) {
            Animals.Add(name);
        }
    }
}
