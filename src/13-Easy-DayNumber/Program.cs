using System;
using Util;

namespace _13_Easy_DayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in a date on the command-line
            // e.g. 8/2/2018 represents February 8th, 2018
            // Then calculate the day number.
            // January 1st should return 1
            // December 31st should return 365 for a non leap year
            var calculator = new DayNumberCalculator();

            if (!calculator.IsValidCommandLine(args))
            {
                Console.WriteLine("Invalid command line.\nPlease specify a valid date in yyyy/mm/dd format");
                return;
            }

            try
            {
                var output = calculator.GetDayNumber(args[0]);
                Console.WriteLine("Day number for {0} is {1}", args[0], output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            ConsoleUtils.WaitForEscape();
        }
    }
}
