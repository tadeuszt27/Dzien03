using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Product   
    {
        private int id;
        private string name;
        private double price;
        private string descr = string.Empty; // "";
        
        private bool promo = false;   // czy jest promocja na produkt
        private bool active = true;   // czy produkt jest dostepny

        public string Name { get { return name; } }  // żeby sięgnac do obiektu klasy Product i sprawdzić nazwe
        public double Price { get { return price; } }

        public Product(int id, string name, double price, string descr = "")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }
    }
}
