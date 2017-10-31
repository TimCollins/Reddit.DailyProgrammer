using System;
using Util;

namespace _11_Int_Upside_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1961;
            var calculator = new UpsideUpCalculator();
            //Console.WriteLine(input + " is " + calculator.IsUpsideUp(input));
            var next = calculator.GetNextAfter(1961);
            Console.WriteLine("The next upside up number after 1961 is " + next);
            ConsoleUtils.WaitForEscape();
        }
    }
}
