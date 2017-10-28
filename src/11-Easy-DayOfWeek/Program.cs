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
            var calculator = new DayOfWeekCalculator();

            if (!calculator.IsValidCommandLine(args))
            {
                return;
            }

            int day, month, year;

            calculator.ParseArg(args[0], out day);
            calculator.ParseArg(args[1], out month);
            calculator.ParseArg(args[2], out year);

            var dayStr = new DayOfWeekCalculator().GetDayOfWeek(day, month, year);
            Console.WriteLine("{0}/{1}/{2} is a {3}", day, month, year, dayStr);
        
            ConsoleUtils.WaitForEscape();
        }
    }
}
