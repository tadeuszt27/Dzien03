using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operatory
{
    
    // Przeciążanie Operatorów by TT
    
    class Wektor
    {
        double x;
        double y;

        public Wektor(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        public Wektor Add(Wektor w)     // tworzymy metode dodajaca dwa wektory
        {
            return new Wektor(x + w.x, y + w.y);
        }

        public Wektor Add(double c)     // tworzymy metode dodajaca liczbé do wektory
        {
            return new Wektor(x + c, y + c);
        }

        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.x + w2.x, w1.y + w2.y);
        }

        public static Wektor operator +(Wektor w1, double c)
        {
            return new Wektor(w1.x + c, w1.y + c);
        }
    }
}
