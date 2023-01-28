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
            double w =mp.PodajTemperature("warszawa", 'k');

            Console.WriteLine(w) ;
            Console.ReadKey();
        }
    }
}
