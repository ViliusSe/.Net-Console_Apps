using _20231128HomeWork.Interfaces;
using _20231128HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Services
{
    internal class CartService : ICart
    {
        Cart cart = new Cart();
        public void AddToCart(string data)
        {
            cart.addedItems.Add(data);
            Console.WriteLine("Added to Cart");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Pirkejo balansas yra {cart.balance} EUR");
        }

        public void ShowCart()
        {
            string result = "";
            foreach (string str in cart.addedItems) result += "\n" + str;
            Console.WriteLine($"Prideti pirkiniai {result}");
        }
    }
}
