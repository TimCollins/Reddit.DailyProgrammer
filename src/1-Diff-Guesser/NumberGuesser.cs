namespace _1_Diff_Guesser
{
    class NumberGuesser
    {
        public static int NoGuesses { get; set; }
        private static int Min { get; set; }
        private static int Max { get; set; }

        public static void ParseInput(char input)
        {
            NoGuesses++;

            if (Min == 0 && Max == 0)
            {
                // First time through start at 50
                Max = 50;
            }

            switch (input)
            {
                case 'h':
                    Min = Max;
                    Max += (Max / 2);
                    break;
                case 'l':
                    Min += (Min / 2);
                    Max = Min;
                    break;
            }
        }
    }
}
