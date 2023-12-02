using _20231128ClassService.Interface;
using _20231128ClassService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128ClassService.Services
{
    internal class Class1 : IShopItemService
    {
        public void ShowAge(ShopItem age)
        {
            Console.WriteLine("bebras " + age.Age);
        }

        public void ShowName(ShopItem name)
        {
            Console.WriteLine($"{name.Name}");
        }
    }
}
