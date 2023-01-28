using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieKalkulator
{
    enum Operator
    {
        Dodawanie,
        Odejmowanie,
        Mnozenie,
        Dzielenie,
        Potegowanie
    }
    internal class Kalkulator
    {
        public double WykonajOperacje(int a, int b, Operator typOperacji)
        {
            if (typOperacji == Operator.Dodawanie)
                return dodaj(a, b);

            if (typOperacji == Operator.Odejmowanie)
                return odejmij(a,b);

            if (typOperacji == Operator.Mnozenie)
                return przemnoz(a,b);

            if (typOperacji == Operator.Dzielenie)
                return podziel(a,b);

            if (typOperacji == Operator.Potegowanie)
                return poteguj(a,b);

            throw new Exception("nieznany operator");
        }

        private int dodaj(int a , int b)
        {
            return a + b;
        }
        private int odejmij(int a, int b)
        {
            return a - b;
        }

        private int przemnoz(int a, int b)
        {
            return a * b;
        }

        private double podziel(int a, int b)
        {
            return Convert.ToDouble(a) / b;
        }

        private double poteguj(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}
