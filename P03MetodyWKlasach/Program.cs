using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03MetodyWKlasach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            int a = 3;

            int c= k.DodajLiczby(a, 4);


            k.DodajLiczby(4, 5);


            string s = k.PrzemnozLiczby(4, 5);

             

           // Console.WriteLine(c);
        }
    }
}
