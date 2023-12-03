using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork.LINQ
{
    internal class LinqStarter
    {
        public void innerLinqMethod()
        {
            Animal dog = new Animal("Rex", 5);
            Animal cat = new Animal("Felix", 7);
            Animal rat = new Animal("Ratatui", 2);
            Animal hamster = new Animal("Putzano", 1);

            Person person1 = new Person("Jhon");
            Person person2 = new Person("Steve");
            Person person3 = new Person("Ann");

            person1.AddAnimal(dog);
            person1.AddAnimal(cat);

            person2.AddAnimal(rat);
            person2.AddAnimal(cat);

            person3.AddAnimal(hamster);
            person3.AddAnimal(dog);

            List<Person> allPersons = new List<Person>();
            allPersons.Add(person1);
            allPersons.Add(person2);
            allPersons.Add(person3);

            List<Animal> BunchOfAnimals = allPersons.SelectMany(animList => animList.Animals).ToList();
            Console.WriteLine("Visi gyvunu vardai :");
            foreach (Animal animal in BunchOfAnimals)
            {
                Console.WriteLine(animal.Name);
            }
            List<Animal> namesWithA = BunchOfAnimals.Where(anim => anim.Name.StartsWith("R")).ToList();
            Console.WriteLine("Vardai is R raides :");
            foreach (Animal animal in namesWithA)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> oldAnimals = BunchOfAnimals.Where(anim => anim.Age >= 5).ToList();
            Console.WriteLine("Seni gyvunai :");
            foreach (Animal animal in oldAnimals)
            {
                Console.WriteLine(animal.Name);
            }


            //allPersons.Select(person =>
            //{
            //    person.Animals.SelectMany(animals =>
            //    {
            //        Console.WriteLine(animals.Name);

            //    });
            //});
        }



    }
}
