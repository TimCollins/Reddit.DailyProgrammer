using System.Linq;

namespace _11_Hard_Calendar
{
    public class CalendarGenerator
    {
        public bool IsValidCommandLine(string[] args)
        {
            if (args.Length != 2)
            {
                return false;
            }

            int month;
            var res = ParseArg(args[0], out month);

            return res;
        }

        /// <summary>
        /// The command line arguments are to be in the form "-tn"
        /// Where t is "m" or "y" and n is a number
        /// </summary>
        public bool ParseArg(string s, out int i)
        {
            if (s.Length < 3)
            {
                i = -1;
                return false;
            }

            var allowedSwitches = new[] { "m", "y" };
            var t = s.Substring(1, 1).ToLower();

            if (!allowedSwitches.Contains(t))
            {
                i = -1;
                return false;
            }

            if (t == "m")
            {
                if (!int.TryParse(s.Substring(2), out i))
                {
                    return false;
                }

                if (i < 1 || i > 12)
                {
                    return false;
                }

                return true;
            }

            // Fix this to handle the year
            return int.TryParse(s.Substring(2), out i);
        }
    }
}
