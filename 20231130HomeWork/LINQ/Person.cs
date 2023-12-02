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

        public List<Animal> Animals { get; set; }

        //Konstruktorius
        public Person(string name, List<Animal> animalsNames) {
            this.Name = name;
            this.Animals = new List<Animal>();
            animalsNames.ForEach((aName) =>
            {
                this.Animals.Add(aName);
            });
        }
        public void AddAnimal(string name) {
            Animal animal = new Animal(name);
            Animals.Add(animal);
        }


        
    }
}
