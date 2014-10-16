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
                // Ignore space
                if (c == 32)
                {
                    output.Append(c);
                }
                else
                {
                    char shifted = (char) (c + shiftDistance);

                    if (shifted > 156)
                    {
                        // If the char is now above '~' in the ASCII table then wrap around.
                        shifted = (char) (shifted - 123);
                    }
                    else if (shifted < 33)
                    {
                        // If the char is now lower in the ASCII table than '!' then wrap around.
                        shifted = (char) (shifted + 93);
                    }

                    output.Append(shifted);
                }
            }

            return output.ToString();
        }

        public static string Decrypt(string input)
        {
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                // Ignore space
                if (c == 32)
                {
                    output.Append(c);
                }
                else
                {
                    char shifted = (char) (c - shiftDistance);

                    if (shifted > 156)
                    {
                        // If the char is now above '~' in the ASCII table then wrap around.
                        shifted = (char) (shifted - 123);
                    }
                    else if (shifted < 33)
                    {
                        // If the char is now lower in the ASCII table than '!' then wrap around.
                        shifted = (char) (shifted + 93);
                    }

                    output.Append(shifted);
                }
            }

            return output.ToString();
        }
    }
}
