using System;
using System.Collections.Generic;
using Util;

namespace _14_Int_Sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            var calculator = new Sieve();

            Console.WriteLine(calculator.FormatPrimes(calculator.CalculatePrimes(max)));
            ConsoleUtils.WaitForEscape();
        }
    }
}
