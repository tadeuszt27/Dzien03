using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Figury
{
    class Trojkat : Figura
    {
        double? bokA = null;
        double? bokB = null;
        double? bokC = null;
        double? wysokosc = null;

        public Trojkat(double bokA, double bokB, double bokC)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
            liczbaBokow = 3;
        }

        public Trojkat(double a, double h)
        {
            bokA = a;
            wysokosc = h;
            liczbaBokow = 3;
        }

        public double ObliczObwod()
        {
            if (wysokosc != null)
            {
                return 0;
            }
            else
            {
                return (double)bokA + (double)bokB + (double)bokC;
            }
        }

        public double ObliczPole()
        {
            if (bokA != null && wysokosc != null)
            {
                return 0.5 * (double)bokA * (double)wysokosc;
            }
            else
            {
                double p = 0.5 * ((double)bokA + (double)bokB + (double)bokC);
                return Math.Sqrt(p * (p - (double)bokA) * (p - (double)bokB) * (p - (double)bokC));
            }
        }
    }
}
