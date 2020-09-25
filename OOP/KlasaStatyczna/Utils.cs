using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaStatyczna
{
    static public class Utils
    {
        public static readonly string hostname = "192.168.0.1";  // pola klasy statycznej nie sa statyczne z definicji
        public static int portNumber = 8080;                     

        public static int GetMaxValue (params int[] args)   // stworzylismy sobie metode ale taka deklaracja ze slowem "params" to nie tablica tylko zmienna liczba argumentów
        {
            return args.Max();                             // metoda Max() byla juz zdefiniowana dla tablicy intów, wszystko co jest dostépne listuje sié po kropce
        }
    }
}
