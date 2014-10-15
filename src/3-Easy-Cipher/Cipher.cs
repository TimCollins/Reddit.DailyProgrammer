using System;
using System.Text;

namespace _3_Easy_Cipher
{
    public static class Cipher
    {
        private const int shiftDistance = 3;

        public static string Encrypt(string input)
        {
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                char shifted = (char) (c + shiftDistance);

                if (shifted > 'z')
                {
                    shifted = (char)(shifted - 26);
                }
                else if (shifted < 'a')
                {
                    shifted = (char)(shifted + 26);
                }

                output.Append(shifted);
            }

            return output.ToString();
        }

        public static string Decrypt(string input)
        {
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                //char shifted = Char.IsLetterOrDigit(c) ? c : (char)(c - shiftDistance);
                char shifted = (char) (c - shiftDistance);

                if (shifted > 'z')
                {
                    shifted = (char)(shifted - 26);
                }
                else if (shifted < 'a')
                {
                    shifted = (char)(shifted + 26);
                }

                output.Append(shifted);
            }

            return output.ToString();
        }
    }
}
