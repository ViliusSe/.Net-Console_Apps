using _20231128HomeWork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231128HomeWork.Interfaces
{
    internal interface IFileService
    {
        public void ReadFileShop();
        public void ReadFileCart();
        public void WriteToFile(List<ShopItemService> data);
        public void WriteToFileCart(Cart data);


    }
}
