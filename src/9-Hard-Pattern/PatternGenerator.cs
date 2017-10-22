using System.Text;

namespace _9_Hard_Pattern
{
    /// <summary>
    /// See http://oeis.org/A005150
    /// </summary>
    public static class PatternGenerator
    {
        public static string Calculate(string s)
        {
            var output = new StringBuilder();
            var cnt = 1;
            var charCount = 1;
            var currentChar = s[0];

            while (cnt < s.Length)
            {
                if (currentChar == s[cnt])
                {
                    charCount++;
                }
                else
                {
                    output.Append(charCount);
                    output.Append(currentChar);
                    charCount = 1;
                    currentChar = s[cnt];
                }
                cnt++;
            }

            output.Append(charCount);
            output.Append(currentChar);

            return output.ToString();
        }
    }
}
