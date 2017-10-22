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
            // Just return straight away if only one iteration has been specified
            if (iterations == 1)
            {
                return "1";
            }

            var output = "1";
            var tmpStorage = new StringBuilder();
            
            for (var i = 1; i < iterations; i++)
            {
                // There will always be at least one character to iterate over
                // As a result that character will always have occurred once
                var cnt = 1;
                var charCount = 1;
                var currentChar = output[0];

                // Loop through the data string
                while (cnt < output.Length)
                {
                    // If the current character matches the next one in the string 
                    // then increment the counter
                    if (currentChar == output[cnt])
                    {
                        charCount++;
                    }
                    else
                    {
                        // Otherwise add the number of occurences of the current character
                        // and the current character itself to tmpStorage
                        tmpStorage.Append(charCount);
                        tmpStorage.Append(currentChar);
                        // Reset the character count
                        charCount = 1;
                        // And get the next character in the array
                        currentChar = output[cnt];
                    }
                    // Increment the loop counter
                    cnt++;
                }

                // Having gone through the string, add the number of occurences of the 
                // current character and the current character itself to tmpStorage
                tmpStorage.Append(charCount);
                tmpStorage.Append(currentChar);

                // Save the current state of the output string and clear it, ready to start again
                // on another iteration
                output = tmpStorage.ToString();
                tmpStorage = new StringBuilder();
            }

            return output;
        }
    }
}
