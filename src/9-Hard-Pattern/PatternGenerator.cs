using System.Text;

namespace _9_Hard_Pattern
{
    /// <summary>
    /// See http://oeis.org/A005150
    /// </summary>
    public static class PatternGenerator
    {
        public static string Calculate(int iterations)
        {
            if (iterations == 1)
            {
                return "1";
            }

            var data = "1";
            var output = new StringBuilder();
            iterations--;

            for (var i = 0; i < iterations; i++)
            {
                var cnt = 1;
                var charCount = 1;
                var currentChar = data[0];

                while (cnt < data.Length)
                {
                    if (currentChar == data[cnt])
                    {
                        charCount++;
                    }
                    else
                    {
                        output.Append(charCount);
                        output.Append(currentChar);
                        charCount = 1;
                        currentChar = data[cnt];
                    }
                    cnt++;
                }

                output.Append(charCount);
                output.Append(currentChar);

                data = output.ToString();
                output = new StringBuilder();
            }

            return data;
        }
    }
}
