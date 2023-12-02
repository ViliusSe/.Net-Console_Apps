using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Debugger.Paveldejimas
{
    abstract class Animal
    {
        public string Name;

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public abstract void Eat();

    }
}
