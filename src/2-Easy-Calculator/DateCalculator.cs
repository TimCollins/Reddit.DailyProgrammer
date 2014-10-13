using System;
using System.Collections.Generic;

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

            return new DateTime(Convert.ToInt32(parts[2]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[0]));
        }

        public static int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate)
            {
                throw new ArgumentException("endDate");
            }

            TimeSpan daysSpan = endDate - startDate;
            List<DayOfWeek> days = new List<DayOfWeek>();

            for (int i = 0; i < daysSpan.Days; i++)
            {
                days.Add(startDate.DayOfWeek);
                startDate = startDate.AddDays(1);
            }

            // Loop through the collection. 
            // For each day, if it's a Saturday or Sunday remove it from the collection.
            for (int i = 0; i < days.Count; i++)
            {
                if (days[i] == DayOfWeek.Saturday || days[i] == DayOfWeek.Sunday)
                {
                    days.Remove(days[i]);
                }

                if (i == days.Count)
                {
                    break;
                }
            }

            return days.Count;
        }
    }
}
