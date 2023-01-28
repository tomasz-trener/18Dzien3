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
                return a + b;

            if (typOperacji == Operator.Odejmowanie)
                return a - b;

            if (typOperacji == Operator.Mnozenie)
                return a * b;

            if (typOperacji == Operator.Dzielenie)
                return a / b;

            if (typOperacji == Operator.Potegowanie)
                return Math.Pow(a,b);

            throw new Exception("nieznany operator");
        }
    }
}
