using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Swich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 4;
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                default:
                    Console.WriteLine("inna");
                    break;
            }

            if(liczba ==1)
                Console.WriteLine("jeden");
            else if (liczba == 2 /*&& ...*/)
                Console.WriteLine("dwa");
            else if (liczba == 3)
                Console.WriteLine("trzy");
            else 
                Console.WriteLine("inna");


        }
    }
}
