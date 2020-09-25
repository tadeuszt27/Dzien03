using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Dziedziczenie
{
    public class Samochod : Pojazd 
    {
        public Samochod()
        {
            czySilnikowy = false;
        }

        public void Uruchom()
        {
            Console.WriteLine("Samochód - uruchom");
        }
    }
}
