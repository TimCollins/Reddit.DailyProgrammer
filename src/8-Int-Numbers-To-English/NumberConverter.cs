namespace _8_Int_Numbers_To_English
{
    public static class NumberConverter
    {
        public static string Convert(int number)
        {
            // Need to break the number down into unit, tens, hundreds.
            // 100 / 10 = 10
            // 100 % 10 = 0
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return string.Empty;
        }
    }
}
