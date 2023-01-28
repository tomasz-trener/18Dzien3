using P07KalkulatorPodzialPracy.Operacje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07KalkulatorPodzialPracy
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

        public double WykonajOperacje(int a, int b , Operator typOperacji)
        {
            if (typOperacji == Operator.Dodawanie)
            {
                OperacjaDodawanie od = new OperacjaDodawanie();
                return od.WykonajOperacje(a, b);
            }

            if (typOperacji == Operator.Odejmowanie)
                return new OperacjaOdejmowanie().WykonajOperacje(a, b);

            if (typOperacji == Operator.Mnozenie)
                return new OperacjaMnozenie().WykonajOperacje(a, b);

            if (typOperacji == Operator.Dzielenie)
                return new OperacjaDzielenie().WykonajOperacje(a, b);

            if (typOperacji == Operator.Potegowanie)
                return new OperacjaPotegowanie().WykonajOperacje(a, b);

            throw new Exception("nieznany operator");
        }

    }
}
