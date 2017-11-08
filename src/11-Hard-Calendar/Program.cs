using System;
using Util;

namespace _11_Hard_Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalendarGenerator();

            if (!calculator.IsValidCommandLine(args))
            {
                Console.WriteLine("Invalid command line.");
                return;
            }

            int month, year;

            if (!calculator.ParseArg(args[0], out month))
            {
                Console.WriteLine("Invalid month parameter.");
                return;
            }

            if (!calculator.ParseArg(args[1], out year))
            {
                Console.WriteLine("Invalid command year.");
                return;
            }

            var output = calculator.GetCalendar(month, year);

            // See https://stackoverflow.com/q/2743260/137001
            // for coloured console output.
            Console.WriteLine(output);

            ConsoleUtils.WaitForEscape();
        }
    }
}
