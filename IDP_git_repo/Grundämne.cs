using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP_assg_3
{
    internal class Grundämne
    {
        public string namn;
        public int Z;
        public string typ;
        public double smältpunkt;
        public double kokpunkt;

        public Grundämne(string aNamn, int aZ, string aTyp, double aSmältpunkt, double aKokpunkt)
        {
            namn= aNamn;
            Z= aZ;
            typ= aTyp;
            smältpunkt = aSmältpunkt;
            kokpunkt= aKokpunkt;
        }
        public void Print()
        {
            Console.WriteLine($"Grundämne: {namn}");
            Console.WriteLine($"Typ: {typ}");
            Console.WriteLine($"Smältpunkt: {smältpunkt}");
            Console.WriteLine($"Kokpunkt: {kokpunkt}");
            Console.WriteLine();
        }
    }


}
