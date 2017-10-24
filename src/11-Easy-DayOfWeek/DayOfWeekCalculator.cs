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
            if (!int.TryParse(args[0], out day))
            {
                return false;
            }

            if (day < 0 || day > 6)
            {
                return false;
            }

            return true;
        }
    }
}
