using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(double bok) : base(bok, bok)  // tu obydwa argumenty klasy rodzica przyjmuja ta sama wartosc bok
        {
            Console.WriteLine("Konstruktor klasy Kwadrat");
        }

        public int CzyKwadrat()      // to jest nasza metoda, która wola metode rodzica 
        {
            //if (base.czyKwadrat())
            //{
            //    return 1;          // i jesli w metodzie rodzica bylo True to zwracamy 1
            //} else
            //{
            //    return 0;          // a jesli False to zwracamy 0
            //}
            return base.CzyKwadrat() ? 1 : 0;  // Pytajnik powoduje, ze jesli po nim jest True to zwraca 1 a jesli Faulse to 0 
        }
    }
}
