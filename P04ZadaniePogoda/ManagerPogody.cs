﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePogoda
{
    internal class ManagerPogody
    {

        public double PodajTemperature(string miasto, char jedn)
        {
            string url = $"https://www.google.com/search?q=pogoda+{miasto}";
            string dane = new WebClient().DownloadString(url);
            //   Console.WriteLine(dane);
            //File.WriteAllText("c:\\dane\\strona.html", dane);

            string szukanyZnak = "°";
            string znakKoncowy = ">";

            int indx = dane.IndexOf(szukanyZnak);
            int aktualnaPozycja = indx;

            while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                aktualnaPozycja--; // zmniejsz o 1     aktualnapozycja = atktualnapozycja - 1

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

            int w= Convert.ToInt32(wynik.Substring(0,wynik.Length-2));

            return TransformujTemperature(jedn, w);
        }

        private double TransformujTemperature(char jedn, int temp) 
        {
            if (jedn == 'c')
                return temp;

            if (jedn == 'f')
                return temp * 1.8 + 32;

            if (jedn == 'k')
                return temp + 273.15;


            // return 0;
            // jak wiemy, ze coś jest nie tak
            // to rzuc błędem 
            throw new Exception("Nieznana jednostka");
        }


        // dodaj opcje aby mozna bylo podac 
        // temeprature w roznych jednostkach:
        // celcjusz, farenheit lub kelvin
    }
}