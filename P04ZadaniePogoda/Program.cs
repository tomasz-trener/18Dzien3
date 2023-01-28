using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();

            mp.Jednostka = 'k';

            double w =mp.PodajTemperature("warszawa"/*, 'k'*/);
            w = mp.PodajTemperature("kraków"/*, 'k'*/);


            Console.WriteLine(w) ;
            Console.ReadKey();
        }
    }
}
