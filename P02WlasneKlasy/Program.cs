using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient f = new WebClient();

           // Program p = new Program();

            // powołanie do życia
            // obiektu kalkulator 

            // stworzenie nowej instancji
            // klasy kalkulator i od 
            // razu przypisujemy tę nową
            // instancję do zmiennej o 
            // nazwie x ,typu Kalkulator 

            Kalkulator x= new Kalkulator();

            Kalkulator x2 = new Kalkulator();
            // deklaracja zmiennej y 
            // typu kalkulator
            // taka zmienna tylko sobie 
            // czeka na to az kiedys 
            // ktoś do niej przypisze 
            // nową instancje kalkulator 
            Kalkulator y;


            // tworzy nowa instacje kalkulatora
            // czy mozemy z niego korzystac? tak
            // jest to jednak pewien problem
            // bo nie mam do tego kalkulatora 
            // uchwytu w postaci zminnej
            // ten kalkulator pływa sobie w gdzieś w pamieci
            // naszego komputera 
            new Kalkulator();



        }
    }
}
