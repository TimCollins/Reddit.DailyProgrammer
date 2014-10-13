using System;
using System.Linq;

namespace _2_Easy_Calculator
{
    public static class DateCalculator
    {
        public static DateTime GetDateFromString(string date)
        {
            string[] parts = date.Split('/');

            if (parts.Length != 3)
            {
                throw new ArgumentException("date");
            }

            int year;
            int month;
            int day;

            if (!Int32.TryParse(parts[2], out year))
            {
                throw new ArgumentException("date");
            }

            if (!Int32.TryParse(parts[1], out month))
            {
                throw new ArgumentException("date");
            }

            if (!Int32.TryParse(parts[0], out day))
            {
                throw new ArgumentException("date");
            }

            if (year < 1 || month < 1 || day < 1)
            {
                throw new ArgumentException("date");
            }

            //ArgumentException
            // IndexOutOfRangeException
            // ArgumentOutofRangeException
            return new DateTime(Convert.ToInt32(parts[2]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[0]));
        }

        public static int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            return 1;
        }
    }
}
