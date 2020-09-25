using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Dziedziczenie
{
    public class Pojazd
    {
        protected int liczbaKol;
        protected int liczbaDrzwi;
        protected int predkoscMax;
        protected bool czySilnikowy;

        
        public void Uruchom()
        {
           Console.WriteLine("Pojazd - uruchom");
        }

        public void Zatankuj()
        {
           Console.WriteLine("Pojazd - zatankuj");
        }

        public void Zatrzymaj()
        {
           Console.WriteLine("Pojazd - zatrzymaj");
        }
    }
}
