using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P08PrzeciazanieMetodIKonstruktorow
{
    enum TypOperacji
    {
        Dodawanie,
        Odejmowanie
    }

    internal class Kalkulator
    {


        public Kalkulator()
        {

        }

        public Kalkulator(TypOperacji typOperacji)
        {

        }

        public Kalkulator(TypOperacji typOperacji, int maxLiczbaOperacji)
        {

        }

        public string Dodaj(int a)
        {
            return Convert.ToString(a);
        }

        /// <summary>
        /// Ta metoda pozwala na dodawanie liczb
        /// </summary>
        /// <param name="a">Pierwsza liczba</param>
        /// <param name="b">Druga Liczba</param>
        /// <returns>Wynik jako suma tych liczb</returns>
        public int Dodaj(int a, int b)
        {
            return a + b;
        }


        //public string Dodaj(int a, int b)
        //{

        //}

        public int Dodaj(string a, string b)
        {
            //5,4
           // return Convert.ToInt32(a + b);
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }

        public int Dodaj(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Ta metoda odejmuje liczby
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Odejmij(int a, int b)
        {
            return a - b;
        }
    }
}
