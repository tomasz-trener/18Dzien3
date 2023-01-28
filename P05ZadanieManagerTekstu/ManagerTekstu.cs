using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    enum TypSzukania
    {
        Jeden,
        Wiele
    }


    internal class ManagerTekstu
    {
        public TypSzukania IleWyrazow { get; set; }


        public ManagerTekstu(TypSzukania ileWyrazow)
        {
            IleWyrazow = ileWyrazow;
        }



        public string[] PodajWyrazy(string zdanie)
        {
            if (IleWyrazow == TypSzukania.Jeden)
                return new string[1] { znajdzNajdluzszyWyraz(zdanie) };

            if (IleWyrazow == TypSzukania.Wiele)
                return znajdzWszystkieNajdluzszeWyrazy(zdanie);

            throw new Exception("Nieznany parametr IleWyrazow");
        }

        private string znajdzNajdluzszyWyraz(string zdanie)
        {
            string[] wyrazy = zdanie.Split(' ');

            string aktualnieNajdluzszy = "";

            for (int i = 0; i < wyrazy.Length; i++)
                if (wyrazy[i].Length > aktualnieNajdluzszy.Length)
                    aktualnieNajdluzszy = wyrazy[i];

            return aktualnieNajdluzszy;
        }

        private string[] znajdzWszystkieNajdluzszeWyrazy(string zdanie)
        {
            string najdluzszy = znajdzNajdluzszyWyraz(zdanie);

            return podajWyrazyOPodanejDlugosci(najdluzszy.Length, zdanie);
        }

        private string[] podajWyrazyOPodanejDlugosci(int dlugosc, string zdanie)
        {
            List<string> znalezione = new List<string>();
            string[] wyrazy = zdanie.Split(' ');

            for (int i = 0; i < wyrazy.Length; i++)
                if (wyrazy[i].Length == dlugosc)
                    znalezione.Add(wyrazy[i]);

            return znalezione.ToArray();
        }


    }
}
