using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasyAbstrakcyjne
{
    class Product : AbstractProduct
    {
        public Product(String name, double price) : base(name, price)
        {

        }

        public override void ShowPrice()
        {
            Console.WriteLine("cena = {0}", price);
        }
    }
}
