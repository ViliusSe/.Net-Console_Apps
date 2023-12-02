using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Models
{
    internal class Cart
    {
        public float balance { get; set; }
        public List<string> addedItems = new List<string>();
    }
}
