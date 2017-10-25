using System.Linq;

namespace _11_Easy_DayOfWeek
{
    public class DayOfWeekCalculator
    {
        public string GetDayOfWeek(int day, int month, int year)
        {
            return "Monday";
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

            if (day < 0 || day > 6)
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
        private bool ParseArg(string s, out int i)
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
                : int.TryParse(s.Substring(2, 1), out i);
        }
    }
}
