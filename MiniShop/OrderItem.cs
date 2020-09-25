using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class OrderItem    // w ramach zamówienia Order mamy pozycje zamowienia (lista zamówien na poszczególnych pozycjach zamówienia)
    {
        private Product product;
        private int qnty;

        // powyzsze pola sa prywatne a chcemy je udostepnic na zewnatrz wiec tworzymy propertisy
        public int Qnty
        {
            get { return qnty; }
            set { qnty = value; }
        }
        public Product Produkt { get { return product; } }  // przez przypadek ta propertis ma nazwe taka jak klasa i jest OK, ale zmienilem na polska nazwe

        public OrderItem(Product p, int q)  // tworzymy konstruktor klasy który ladowalby rzeczy które wchodzily by na stan OrderItems
        {
            product = p;
            qnty = q;
        }
    }
}
