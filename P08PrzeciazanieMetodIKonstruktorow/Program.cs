using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08PrzeciazanieMetodIKonstruktorow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator(TypOperacji.Dodawanie,2);
            
            int a= k.Dodaj(2, 4);

            a = k.Dodaj(5, 4);
            
            a = k.Dodaj(1, 4);

            int b = k.Odejmij(5, 3);
        }
    }
}
