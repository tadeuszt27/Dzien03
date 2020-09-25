using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    public class Samochod
    {
        private String marka;
        private int predkoscMax;

        // deklaracja property (właściwości)
        public int PredkoscMax
        {
            get { return predkoscMax; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Coś chyba nie tak, kolego!");
                }
                else
                {
                    predkoscMax = value;    //value to słowo kluczowe wskazujące ogólnie na wartość, bo tu nie przekazujemy żadnej zmiennej tak jak w metodach 
                }
            }
        }
        public Samochod(String marka, int predkoscMax)
        {
            this.marka = marka;
            this.predkoscMax = predkoscMax;
        }

        public Samochod(String marka)
        {
            this.marka = marka;
            predkoscMax = 100;
        }
        
        /// <summary>
        /// Metoda zmienia prędkość maksymalną
        /// </summary>
        /// <param name="nowaPredkoscMax">nowa prędkość jako Int32</param>
                        
        public void UstawPredkoscMax(int nowaPredkoscMax)
        {
            predkoscMax = nowaPredkoscMax;
        }


        public int PobierzPredkoscMax()
        {
            return predkoscMax;
        }

        public void Print()
        {
            Console.WriteLine(
                String.Format("Marka={0}, predkość maks={1}", marka, predkoscMax));
        }

        
    }
}
