using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Debugger
{
    abstract class AbstractClass
    {
        public abstract string Name { get; set; }

        public abstract void AbstractMethod();
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}
