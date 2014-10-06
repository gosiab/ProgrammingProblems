using System.Numerics;

namespace FactorialCalculatorSource
{
    public class FactorialCalc
    {

        public BigInteger Factorial(int number)
        {
            if (number >= 0)
            {
                BigInteger numberFactorial = 1;

                for (var i = 1; i <= number; i++)
                {
                    numberFactorial = numberFactorial * i;
                }

                return numberFactorial;
            }
            return 0;
        }
    }
}
