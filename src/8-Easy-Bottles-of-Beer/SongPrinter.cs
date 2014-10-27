namespace _8_Easy_Bottles_of_Beer
{
    class SongPrinter
    {
        public static string PrintVerse(int bottles)
        {
            if (bottles == 0)
            {
                return "No more bottles of beer on the wall, no more bottles of beer. " +
                       "Go to the store and buy some more, 99 bottles of beer on the wall.";
            }

            return string.Format("{0} {1} of beer on the wall, {0} {1} of beer. " +
                "Take one down and pass it around, {2} {3} of beer on the wall.", bottles, GetPlural(bottles), GetRemainder(bottles - 1), GetRemainderBottles(bottles - 1));
        }

        private static string GetRemainderBottles(int bottles)
        {
            return (bottles == 0 || bottles > 1 ? "bottles" : "bottle");
        }

        private static string GetRemainder(int bottles)
        {
            return (bottles > 0 ? bottles.ToString() : "no more");
        }

        private static string GetPlural(int bottles)
        {
            return (bottles > 1 ? "bottles" : "bottle");
        }
    }
}
