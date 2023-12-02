using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatas
{
    internal class Delegacija
    {
        delegate int NumberChanger(int num);
        delegate string Delegatas(string firstName, string lastName, int age);

        private int Metodas(int n)
        {
            return (n + 2);
        }


        private string DelegatoMetodas(string firstName, string lastName, int age)
        {
            string text = firstName + " " + lastName + " " + age.ToString();
            return text;
        }

        
        //using anonymous function
        public delegate void Print(int value);

        Print prnt = delegate (int val)
        {
            val += 5;
            Console.WriteLine(val);
        };


        public void UseDelegate()
        {
            NumberChanger NumberChager1 = new NumberChanger(Metodas);
            Delegatas Delegatas1 = new Delegatas(DelegatoMetodas);


            Console.WriteLine(NumberChager1(5));
            Console.WriteLine(Delegatas1("jonas", "jonaitis", 5));
            prnt(50); //implementing anonymous function

        }

        

        
    }
}
