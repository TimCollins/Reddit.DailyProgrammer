using System;
using System.Text;

namespace _8_Int_Numbers_To_English
{
    public static class NumberConverter
    {
        public static string Convert(int number)
        {
            StringBuilder output = new StringBuilder();

            if (number < 20)
            {
                output.Append(GetOnesValue(number));
            }
            else if (number < 100)
            {
                int tens, ones;
                CalculateTensAndOnes(number, out tens, out ones);

                output.Append(GetTensValue(tens));
                output.Append(" " + GetOnesValue(ones));
            }
            else if (number < 1000)
            {
                int divisor = 900;
                int modulus = number % divisor;

                while (modulus > 99)
                {
                    divisor -= 100;
                    modulus = number % divisor;
                }

                output.Append(GetHundredsValue(divisor));

                if (modulus > 19)
                {
                    int tens, ones;
                    CalculateTensAndOnes(modulus, out tens, out ones);

                    output.Append(" and " + GetTensValue(tens));
                    output.Append(" " + GetOnesValue(ones));
                }
                else if (modulus > 0)
                {
                    output.Append(" and " + GetOnesValue(modulus));
                }
            }
            else if (number < 10000)
            {
                int divisor = 9000;
                int modulus = number % divisor;

                while (modulus > 999)
                {
                    divisor -= 100;
                    modulus = number % divisor;
                }

                output.Append(GetThousandsValue(divisor));

                while (modulus > 100)
                {
                    divisor -= 100;
                    modulus = number % divisor;
                }

                if (modulus > 99)
                {
                    output.Append(GetHundredsValue(divisor));
                }                

                if (modulus > 19)
                {
                    int tens, ones;
                    CalculateTensAndOnes(modulus, out tens, out ones);

                    output.Append(" and " + GetTensValue(tens));
                    output.Append(" " + GetOnesValue(ones));
                }
                else if (modulus > 0)
                {
                    output.Append(" and " + GetOnesValue(modulus));
                }
            }

            return output.ToString();
        }

        private static void CalculateTensAndOnes(int number, out int tens, out int ones)
        {
            int divisor = 90;
            int modulus = number % divisor;

            while (modulus > 10)
            {
                divisor -= 10;
                modulus = number % divisor;
            }

            tens = divisor;
            ones = modulus;
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

        private static string GetHundredsValue(int number)
        {
            switch (number)
            {
                case 100:
                    return "one hundred";
                case 200:
                    return "two hundred";
                case 300:
                    return "three hundred";
                case 400:
                    return "four hundred";
                case 500:
                    return "five hundred";
                case 600:
                    return "six hundred";
                case 700:
                    return "seven hundred";
                case 800:
                    return "eight hundred";
                case 900:
                    return "nine hundred";
            }

            throw new ArgumentException("number");
        }

        private static string GetThousandsValue(int number)
        {
            switch (number)
            {
                case 1000:
                    return "one thousand";
                case 2000:
                    return "two thousand";
                case 3000:
                    return "three thousand";
                case 4000:
                    return "four thousand";
                case 5000:
                    return "five thousand";
                case 6000:
                    return "six thousand";
                case 7000:
                    return "seven thousand";
                case 8000:
                    return "eight thousand";
                case 9000:
                    return "nine thousand";
            }
            
            throw new ArgumentException("number");
        }
    }
}
