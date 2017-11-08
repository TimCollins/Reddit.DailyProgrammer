using System;
using System.Linq;
using System.Text;

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

            int month, year;
            var res = ParseArg(args[0], out month);
            if (!res)
            {
                return false;
            }

            res = ParseArg(args[1], out year);

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
                return DoMonthValidation(s, out i);
            }

            return DoYearValidation(s, out i);
        }

        private bool DoYearValidation(string s, out int i)
        {
            if (s.Length < 6)
            {
                i = -1;
                return false;
            }

            if (!int.TryParse(s.Substring(2, 4), out i))
            {
                return false;
            }

            if (i < 1970 || i > 2038)
            {
                return false;
            }

            return true;
        }

        private static bool DoMonthValidation(string s, out int i)
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

        public string GetCalendar(int month, int year)
        {
            var output = new StringBuilder(string.Format("Calendar for {0}, {1}", GetMonthName(month), year));
            output.Append("\nMo  Tu  We  Th  Fr  Sa  Su");
            output.Append("\n--------------------------\n");

            var day = 1;
            var start = new DateTime(year, month, day);
            var firstDay = start.DayOfWeek.ToString().Substring(0, 2);
            var nextMonth = month < 12 ? month + 1 : 1;
            var lastDayOfMonth = new DateTime(year, nextMonth, 1).AddDays(-1).Day;

            var initialSpaces = 0;
            if (firstDay == "Tu")
            {
                initialSpaces = 1;
            }
            else if (firstDay == "We")
            {
                initialSpaces = 2;
            }
            else if (firstDay == "Th")
            {
                initialSpaces = 3;
            }
            else if (firstDay == "Fr")
            {
                initialSpaces = 4;
            }
            else if (firstDay == "Sa")
            {
                initialSpaces = 5;
            }
            else if (firstDay == "Su")
            {
                initialSpaces = 6;
            }

            for (var i = 0; i < initialSpaces; i++)
            {
                output.Append("    ");
            }

            var cnt = initialSpaces;
            while (day < lastDayOfMonth)
            {
                while (cnt <= 6 && day <= lastDayOfMonth)
                {
                    if (day < 10)
                    {
                        output.Append(" ");
                    }
                    
                    output.Append(day + "  ");
                    day++;
                    cnt++;
                }
                output.Append("\n");
                cnt = 0;
            }

            return output.ToString();
        }

        private string GetMonthName(int month)
        {
            return new DateTime(DateTime.Now.Year, month, DateTime.Now.Day).ToString("MMMM");
        }
    }
}
