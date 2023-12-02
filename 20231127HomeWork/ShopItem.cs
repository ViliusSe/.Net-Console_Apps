using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20231127HomeWork
{
    internal class ShopItem
    {


        public string Name { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags = new List<Tag>();
        public Double Price { get; set; }
        public DateTime Expiration { get; set; }


        public ShopItem() { }
        public ShopItem(string[] tag, string name = "defaultName", string description = "defaultDescription", Double Price = 1.23D)
        {
            this.Name = name;
            this.Description = description;
            this.Tags = TagToList(tag);
            this.Price = Price;
            DateTime now = DateTime.Now;
            this.Expiration = now.AddDays(7);
                            
        }
            private List<Tag> TagToList(string[] arr)  //sudeda paduota name'u masyva i Tagu lista.
        {
            List<Tag> tagsList = new List<Tag>();
            
            foreach(string i in arr)
            {
                Tag tagas = new Tag(i);
                tagsList.Add(tagas);
            }
            return tagsList;
        }

        private string JoinList() //method to prepare Tag data for displaying as string of Tags Names
        {
            string tags = "";
            foreach(var item in Tags) { 
                tags += item.Name + ", ";
            }
            return tags;
        }
        public override string ToString()  //method to show All initiated object parameters.
        {
            return $"Name: {Name}, Description: {Description}, Tags: {JoinList()}, Price: {Price}, Expiration {Expiration} \n";
        }
    }
}
