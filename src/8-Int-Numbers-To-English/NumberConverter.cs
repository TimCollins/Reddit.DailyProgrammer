using System;
using System.Text;

namespace _8_Int_Numbers_To_English
{
    public static class NumberConverter
    {
        public static string Convert(int number)
        {
            // Need to break the number down into unit, tens, hundreds.
            // 100 / 10 = 10
            // 100 % 10 = 0

            // Numbers up to 20 are special cases I think.
            if (number < 20)
            {
                return GetOnesValue(number);
            }

            // Using 25 as an example, need to find which is the second digit and get the modulus.
            // So we check if it's less than 100 and while it's less than 100, get the mod.
            // When the mod < 10 we have the value 
            // 25 < 100 so start by doing 25 mod 90
            // It's > 10 so do 25 mod 80.
            // It's > 10 so do 25 mod 70 etc.
            // 25 % 20 = 5 so we know now that 20 is our tens column
            // We take the remainder (5) as our ones column.
            int divisor = 90;
            int modulus = number % divisor;

            while (modulus > 10)
            {
                divisor -= 10;
                modulus = number % divisor;
            }

            StringBuilder output = new StringBuilder();

            output.Append(GetTensValue(divisor));
            output.Append(" " + GetOnesValue(modulus));

            return output.ToString();
        }

        private static string GetOnesValue(int number)
        {
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
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
            }

            throw new ArgumentException("number");
        }

        private static string GetTensValue(int number)
        {
            switch (number)
            {
                case 10:
                    return "ten";
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "forty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
            }

            throw new ArgumentException("number");
        }

    }
}
