using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a     = 1;
            char b    = 's';
            double c  = 5.6;
            bool d    = false;
            string e  = "ala ma kota"; // string to klasa, która wygląda i działa jak struktura 

            //String ee = new String("ala ma kota");

            WebClient f     = new WebClient();
            DateTime g      = new DateTime(); // to struktura, która działa i wygląda jak klasa
            StringBuilder h = new StringBuilder();


            int[] tab1          = new int[3];
            string[] tab2       = new string[3];

            List<string> lista1 = new List<string>();
            List<int> lista2 = new List<int>();

            List<DateTime> lista3 = new List<DateTime>();
            List<WebClient> lista4 = new List<WebClient>();

            WebClient[] tab3 = new WebClient[3];







        }
    }
}
