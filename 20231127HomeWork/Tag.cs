using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231127HomeWork
{
    internal class Tag
    {
        public Tag(string name) { 
            this.Id = counter++;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        private static int counter;
        
        public void TagData() //Shows data of the tag in format <ID : TagName>
        {
           Console.WriteLine(this.Id + " : " + this.Name);
        }
    }
}
