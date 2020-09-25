using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 180);
            samochod.UstawPredkoscMax(220);                // metoda która zmienia wartość pola predkoscMax
            //int predkosc = samochod.PobierzPredkoscMax();  // metoda która pobiera wartość pola predkoscMax
            samochod.Print();
            
            samochod.PredkoscMax = -10;  // 220;  // zamiast powyższych dwóch metod definiujemy właściwość PredkoscMax która ustawia i pobiera wartość pola predkoscMax
            Console.WriteLine(samochod.PredkoscMax);

            // kolejna instancja obiektu
            Samochod samochod1 = new Samochod("AUDI");
            samochod1.Print();


            Console.ReadKey();
        } 
    }
}
