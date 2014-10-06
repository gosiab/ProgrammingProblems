using FactorialCalculatorSource;
using System;

namespace FactorialCalculatorProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            var doContinue = true;
            while (doContinue)
            {
                Console.Write("Find n! where n =  ");

                try
                {
                    var number = int.Parse(Console.ReadLine());
                    if (number >= 0)
                    {
                        var fc = new FactorialCalc();
                        var result = fc.Factorial(number);
                        Console.WriteLine("n! = " + number + "! = " + result);
                        Console.Write("Continue? y/n: ");
                        var stop = Console.ReadLine();
                        if (stop == "n" || stop == "N")
                        {
                            doContinue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, but n can be only positive!");
                    }
                }
                catch
                {
                    Console.WriteLine("Only numbers you can add!");
                }

            }
        }
    }
}
