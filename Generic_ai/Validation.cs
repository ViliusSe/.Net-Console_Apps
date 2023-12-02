using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_ai
{
    internal class Validation<T>
    {

        static public void Validate<T>(T item) {
            if (item == null)
                 Console.WriteLine("given parameter is null");
            else
                Console.WriteLine("given parameter is not null");
            
           
        }

        public void ValidateObj<T>(T item)
        {
            if (item == null)
                Console.WriteLine("given parameter is null");
            else
                Console.WriteLine("given parameter is not null");


        }
    }
}
