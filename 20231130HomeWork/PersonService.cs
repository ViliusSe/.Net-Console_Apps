using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231130HomeWork
{
    internal class PersonService
    {
        public static bool IsChild(Person person)
        {
            return person.Age < 18;
        }

        public static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }

        public static bool IsSenior(Person person)
        {
            return person.Age >= 65;
        }
    }
}
