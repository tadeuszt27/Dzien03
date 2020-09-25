using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasyAbstrakcyjne
{
    abstract class AbstractProduct
    {
        protected String name;
        protected double price;

        public AbstractProduct(String n, double p)
        {
            name = n; price = p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("info o produkcie: {0} - {1}", name, price);  // Console.Writeline potrafi sam sformatować łańcuch wynikowy który ma być wyświetlany
        }

        public abstract void ShowPrice();   // tak jak w Interface mozemy tylko deklarowac metode która nic nie bedzie robila
    }
}
