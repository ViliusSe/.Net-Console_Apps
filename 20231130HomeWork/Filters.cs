using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork
{

    delegate bool FilterFunction(Person person);
    internal class Filters
    {
        public void DisplayPeople(string title, List<Person> personsList, FilterFunction filter)
        {
            Console.Write(title + ":\n" );
            foreach (Person person in personsList)
            {
                Console.WriteLine(person.Name + " " + person.Age.ToString() + " " + filter(person));
            }
        }
    }
}
