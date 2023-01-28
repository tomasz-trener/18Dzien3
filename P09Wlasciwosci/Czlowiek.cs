using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Wlasciwosci
{
    internal class Czlowiek
    {
        public double Wzrost { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        private int liczbaGlow = 1;

        public string PrzedstawSie()
        {
            return "Nazywam sie" + Imie + " " + Nazwisko +
               $" i mam {liczbaGlow} głowe";
        }
    }
}
