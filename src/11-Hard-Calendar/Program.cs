using System;
using Util;

namespace _11_Hard_Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://stackoverflow.com/q/2743260/137001
            // for coloured console output.
            Console.WriteLine("Calendar for October, 2017");
            Console.WriteLine("Mo  Tu  We  Th  Fr  Sa  Su");
            Console.WriteLine("--------------------------");
            Console.WriteLine("25  26  27  28  29  30   1");
            Console.WriteLine(" 9  10  11  12  13  14  15");
            Console.WriteLine("16  17  18  19  20  21  22");
            Console.WriteLine("23  24  25  26  27  28  29");
            Console.WriteLine("30  31   1   2   3   4   5");
            ConsoleUtils.WaitForEscape();
        }
    }
}
