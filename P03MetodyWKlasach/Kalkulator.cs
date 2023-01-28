using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03MetodyWKlasach
{
    internal class Kalkulator
    {
        public int DodajLiczby(int a, int b)
        {           
            int c = a + b;

            // pewien algorytm (proces)
            c = c + 1;
            c = c - 1;

            return c;
        }

        public void MetodaNicNieZwracjaca()
        {
            // ona tylko coś bedzie robić
            Console.WriteLine("x");
        }

        // zadanie: 
        // dodaj metode, która na wejscie 
        // przyjumuje dwie liczby, mnozy je
        // i zwraca jako tekst informacje
        // z ilu cyfr sklada sie wynik

        //przykład 4,5 -> "2"
        
        public string PrzemnozLiczby(int a, int b)
        {
            //return Convert.ToString(
            //           Convert.ToString(a * b).Length);

            string c = Convert.ToString(a * b);
            return Convert.ToString(podajDlugocNapisu(c));
        }

        private int podajDlugocNapisu(string s)
        {
            return s.Length;
        }


    }
}
