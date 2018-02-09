using System;

namespace _13_Easy_DayNumber
{
    public class DayNumberCalculator
    {
        private DateTime _date;
        private int _year;
        private int _month;
        private int _day;

        public int GetDayNumber(string input)
        {
            if (!Parse(input))
            {
                return -1;
            }

            try
            {
                _date = new DateTime(_year, _month, _day);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return GetDayNumber(_date);
        }

        private bool Parse(string input)
        {
            var parts = input.Split('/');
            if (parts.Length != 3)
            {
                return false;
            }

            if (!int.TryParse(parts[0], out _year))
            {
                return false;
            }

            if (!int.TryParse(parts[1], out _month))
            {
                return false;
            }

            if (!int.TryParse(parts[2], out _day))
            {
                return false;
            }

            return true;
        }

        public int GetDayNumber(DateTime date)
        {
            var yearEnd = new DateTime(date.Year, 12, 31);
            var ts = yearEnd - date;

            return 365 - ts.Days;
        }

        public bool IsValidCommandLine(string[] args)
        {
            return args.Length == 1;
        }
    }
}
