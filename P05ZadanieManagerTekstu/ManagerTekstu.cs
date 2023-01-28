using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {
        public string IleWyrazow { get; set; }


        public string[] PodajWyrazy(string zdanie)
        {
            if (IleWyrazow == "jeden")
                return new string[1] { znajdzNajdluzszyWyraz(zdanie) };

            if (IleWyrazow == "wiele")
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

            for (int i = 0; i < zdanie.Length; i++)
                if (wyrazy[i].Length == dlugosc)
                    znalezione.Add(wyrazy[i]);

            return znalezione.ToArray();
        }


    }
}
