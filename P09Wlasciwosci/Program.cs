using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P09Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k1 = new Kalkulator();
            k1.Waga = 50;

            Kalkulator k2 = new Kalkulator();
            k2.Waga = 100;

            Czlowiek c1 = new Czlowiek();
            c1.Imie = "Jan";
            c1.Nazwisko = "Kowalski";

            Czlowiek c2 = new Czlowiek();
            c2.Imie = "Adam";
            c2.Nazwisko = "Nowak";

            string s = c2.Imie;

            

            Console.WriteLine(c1.PrzedstawSie()); ;
        }
    }
}
