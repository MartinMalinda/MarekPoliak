using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Classes;

namespace Webshop.Models
{
    public class IndexModel
    {
        public string Filter { get; set; }
        public string Search { get; set; }
        public List<ShopItem> List { get; set; } = new List<ShopItem>();

        public IndexModel()
        {
            List.Add(new ShopItem("Running Shoes", "Nike running shoes for every day sport", "1000", "5"));
            List.Add(new ShopItem("Printer", "Some HP printer that will print pages", "3000", "2"));
            List.Add(new ShopItem("Coca cola", "0.5l standard coke", "25", "10"));
            List.Add(new ShopItem("T-shirt", "blue with a corgi on a bike", "300", "1"));
        }
    }
}
