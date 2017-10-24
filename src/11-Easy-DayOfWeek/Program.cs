using System;
using Util;

namespace _11_Easy_DayOfWeek
{
    /// <summary>
    /// The program should take three arguments. The first will be a day, 
    /// the second will be month, and the third will be year. Then, your 
    /// program should compute the day of the week that date will fall on.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if (!IsValidCommandLine(args))
            {
                return;
            }

            var day = Parse(args[0]);
            var month = Parse(args[1]);
            var year = Parse(args[2]);

            var dayStr = new DayOfWeekCalculator().GetDayOfWeek(day, month, year);
            Console.WriteLine("{0}/{1}/{2} is a {3}", day, month, year, dayStr);
        
            ConsoleUtils.WaitForEscape();
        }

        private static int Parse(string arg)
        {
            return 1;
        }

        private static bool IsValidCommandLine(string[] args)
        {
            return args.Length == 3;
        }
    }
}
