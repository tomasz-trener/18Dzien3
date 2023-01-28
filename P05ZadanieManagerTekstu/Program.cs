using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerTekstu mt = new ManagerTekstu();
            mt.IleWyrazow = "wiele";

            string[] wyrazy= mt.PodajWyrazy("ala ma kot i ma psa");

            Console.WriteLine(string.Join(", ", wyrazy));
            Console.ReadKey();
        
        }

    }
}
