using System;
using Util;

namespace _11_Int_Upside_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new UpsideUpCalculator();
            const int input = 1961;
            var next = calculator.GetNextAfter(input);

            Console.WriteLine("The next upside up number after 1961 is " + next);

            var max = 10000;
            var total = calculator.GetTotal(max);
            Console.WriteLine("There are {0} upside up numbers from 0 - 10000", total);

            ConsoleUtils.WaitForEscape();
        }
    }
}
