using System;

namespace P05ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj typ szukania: 'jeden' lub 'wiele'");

            string typ = Console.ReadLine().ToLower();
            TypSzukania? st=null;

            if (typ == "jeden")
                st = TypSzukania.Jeden;
            if (typ == "wiele")
                st = TypSzukania.Wiele;


            if(st != null)
            {
                ManagerTekstu mt = new ManagerTekstu((TypSzukania)st);
                // mt.IleWyrazow = TypSzukania.Wiele;

                string[] wyrazy = mt.PodajWyrazy("ala ma kot i ma psa");

                Console.WriteLine(string.Join(", ", wyrazy));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("podales zly typ");
            }





            string s = "ala*ma^kota";
            s.Split(new string[2] { "*", "^" }, StringSplitOptions.RemoveEmptyEntries);
        
        }

    }
}
