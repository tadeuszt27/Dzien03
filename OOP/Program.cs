using OOP.Dziedziczenie;
using OOP.Figury;
using OOP.KlasaStatyczna;
using OOP.KlasyAbstrakcyjne;
using OOP.Operatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Próba TT

            //Pojazd pojazd = new Pojazd();
            //pojazd.Uruchom();

            //Samochod samochod = new Samochod();
            //samochod.Uruchom();

            //SamochodElektryczny se = new SamochodElektryczny();
            //se.Uruchom();     

            //Trojkat trojkat = new Trojkat(6, 10);           
            //Console.WriteLine(trojkat.ObliczPole());
            //Console.WriteLine(trojkat.ObliczObwod());

            //Prostokat prostokat = new Prostokat(2.5, 5);
            //Console.WriteLine(prostokat.CzyKwadrat());
            //Console.WriteLine(prostokat.ObliczPole());
            //Console.WriteLine(prostokat.ObliczObwod());

            //Kwadrat kwadrat = new Kwadrat(5);
            //Console.WriteLine(kwadrat.CzyKwadrat());
            //Console.WriteLine(kwadrat.ObliczPole());
            //Console.WriteLine(kwadrat.ObliczObwod());

            //Utils.hostname = "127.0.0.1";                           // klasa statyczna Utils nie wymaga kreowania obiektu
            //Console.WriteLine(Utils.GetMaxValue(-10, 1, 10, 100));  // Przyciskajac Ctrl i klikajac w GetMaxValue przeniesie nas do tej metody w klasie Utils

            //Product product = new Product("Mleko", 2.99);
            //product.ShowInfo();
            //product.ShowPrice();

            Wektor wektor1 = new Wektor(1, -2);
            Wektor wektor2 = new Wektor(-4, 10);
            Wektor suma = wektor1 + wektor2;  //wektor1.Add(wektor2);
            suma.Print();
            suma = wektor1 + 10;  //wektor1.Add(10);
            suma.Print();

            Console.ReadKey();
        }
    }
}
