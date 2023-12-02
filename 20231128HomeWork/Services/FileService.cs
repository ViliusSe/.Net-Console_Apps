using _20231128HomeWork.Interfaces;
using _20231128HomeWork.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _20231128HomeWork.Services
{
    internal class FileService : IFileService
    {
        public void ReadFile()
        {
            File.ReadAllText(@"C:/Users/v.senkus/Desktop/Cart.txt");
        }

        public void WriteToFile(List<ShopItemService> list)
        {
            
        }

        internal void WriteToFile(List<ShopItem> list)
        {
            string data = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(@"C:/Users/v.senkus/Desktop/Cart.txt", data);
        }
    }
}
