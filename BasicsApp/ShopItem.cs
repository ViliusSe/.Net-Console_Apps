using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    internal class ShopItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public float Price { get; set; }

        public List<String> Tag = new List<String>();

        public void SetTag(String tag)
        {
            Tag.Add(tag);
        }

        public DateTime ExpiryDate { get; set; }

        public override String ToString()
        {
            return "Name: " + Name + " Description: " + Description + " Tag: " + Tag + " Expire: " + ExpiryDate;
        }
    }
}
