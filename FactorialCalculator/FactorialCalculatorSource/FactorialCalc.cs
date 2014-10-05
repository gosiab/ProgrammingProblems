using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FactorialCalculatorSource
{
    public class FactorialCalc
    {

        public BigInteger Factorial(int number)
        {
            if (number >= 0)
            {


                BigInteger numberFactorial;

                numberFactorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    numberFactorial = numberFactorial * i;
                }

                return numberFactorial;
            }
            else
            {
                return 0;
            }
        }
    }
}
