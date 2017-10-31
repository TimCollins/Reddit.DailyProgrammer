using System.Linq;

namespace _11_Easy_DayOfWeek
{
    public class DayOfWeekCalculator
    {
        public string GetDayOfWeek(int day, int month, int year)
        {
            // See here from some implementation algorithms:
            // https://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week
            //int dayOfWeek = GetKeyValueResult(day, month, year);

            int dayOfWeek = GetKeyValueResult(16, 12, 2482);
            if (dayOfWeek == 0)
            {
                return "Saturday";
            }

            if (dayOfWeek == 1)
            {
                return "Sunday";
            }

            if (dayOfWeek == 2)
            {
                return "Monday";
            }

            if (dayOfWeek == 3)
            {
                return "Tuesday";
            }

            if (dayOfWeek == 4)
            {
                return "Wednesday";
            }

            if (dayOfWeek == 5)
            {
                return "Thursday";
            }

            return "Friday";
        }

        /// <summary>
        /// See http://mathforum.org/dr.math/faq/faq.calendar.html
        /// </summary>
        private int GetKeyValueResult(int day, int month, int year)
        {
            // -d2 -m2 -y1995 should return Thursday
            // -d16 -m12 -y2482 should return Wednesday
            // -d28 -m10 -y2017 should return Saturday

            // Take last 2 digits of year
            var last2Digits = year % 100;
            // Divide by 4, dropping any remainder
            int next = last2Digits / 4;
            // Add the day of the month
            int withMonth = next + day;
            // Add key value for month (each of these could be an individual test)
            withMonth += GetMonthValue(month);
            // If this is January or Feb of a leap year then subtract 1 (also a possible test)
            if (IsLeapYear(year))
            {
                withMonth--;
            }

            // Add the century value (yes, more tests)
            withMonth += GetCenturyValue(year);

            // Add the last two digits of the year
            withMonth += year % 100;

            // Divide by 7 and take the remainder
            var remainder = withMonth % 7;

            return remainder;
        }

        /// <summary>
        /// Possible values are:
        /// 1700s: 4
        /// 1800s: 2
        /// 1900s: 0
        /// 2000s: 6
        /// For values > 2099, keep subtracting 400 until you get a value that is 
        /// in the table e.g. 2482 -> 2082
        /// </summary>
        private int GetCenturyValue(int year)
        {
            while (year > 2000)
            {
                year -= 400;
            }

            if (year >= 1700 && year < 1800)
            {
                return 4;
            }

            if (year >= 1800 && year < 1900)
            {
                return 2;
            }

            if (year >= 1900 && year < 2000)
            {
                return 0;
            }

            return 6;
        }

        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Possible values are:
        /// Jan 1
        /// Feb	4
        /// Mar 4
        /// Apr 0
        /// May 2	
        /// June 5	
        /// July 0
        /// Aug 3
        /// Sept 6
        /// Oct 1
        /// Nov 4
        /// Dec 6
        /// </summary>
        private int GetMonthValue(int month)
        {
            if (month == 3 || month == 6)
            {
                return 0;
            }

            if (month == 0 || month == 9)
            {
                return 1;
            }

            if (month == 4)
            {
                return 2;
            }

            if (month == 7)
            {
                return 3;
            }

            if (month == 1 || month == 2 || month == 10)
            {
                return 4;
            }

            if (month == 5)
            {
                return 5;
            }

            return 6;
        }

        public bool IsValidCommandLine(string[] args)
        {
            if (args.Length != 3)
            {
                return false;
            }

            int day;
            if (!ParseArg(args[0], out day))
            {
                return false;
            }

            // This is wrong
            // For now do 1 - 31 inclusive
            // and work on a better test related to the specified month
            if (day < 1 || day > 31)
            {
                return false;
            }

            int month;
            if (!ParseArg(args[1], out month))
            {
                return false;
            }

            if (month < 0 || month > 11)
            {
                return false;
            }

            int year;
            if (!ParseArg(args[2], out year))
            {
                return false;
            }

            if (year < 1970 || year > 2038)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// The command line arguments are to be in the form -tn
        /// Where t is "d", "m" or "y" and n is a number
        /// </summary>
        public bool ParseArg(string s, out int i)
        {
            if (s.Length < 3)
            {
                i = -1;
                return false;
            }

            var allowedSwitches = new[] {"d", "m", "y"};
            var t = s.Substring(1, 1).ToLower();

            if (!allowedSwitches.Contains(t))
            {
                i = -1;
                return false;
            }

            return t == "y"
                ? int.TryParse(s.Substring(2, 4), out i)
                : int.TryParse(s.Substring(2), out i);
        }
    }
}
