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
                Console.WriteLine("Invalid command line.\nTry 11-Hard-Calendar -m11 -y2017 to produce a calendar for November 2017");
                return;
            }

            int month, year;

            if (!calculator.ParseArg(args[0], out month))
            {
                Console.WriteLine("Invalid month parameter. The month must be between 1 and 12 inclusive.");
                return;
            }

            if (!calculator.ParseArg(args[1], out year))
            {
                Console.WriteLine("Invalid command year. The year must be between 1970 and 2038 inclusive.");
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
