using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Interfaces
{
    internal interface ICart
    {
        public void AddToCart(string data);
        public void ShowBalance();
        public void ShowCart();

    }
}
