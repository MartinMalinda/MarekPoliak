using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Classes
{
    public class ShopItem
    {
        public List<string> Attributes { get; set; }
        public int NumOfAttributes { get; set; } = 4;

        public ShopItem(string name, string description, string price, string quantity)
        {
            Attributes = new List<string>();
            Attributes.Add(name);
            Attributes.Add(description);
            Attributes.Add(price);
            Attributes.Add(quantity);
        }
    }
}
