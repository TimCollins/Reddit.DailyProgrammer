using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Easy_Sorting
{
    public static class Sorter
    {
        public static string Sort(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("input");
            }

            string[] parts = input.Split(new[] {','});          

            if (parts.Length == 1)
            {
                return parts[0];
            }

            List<int> numbers = new List<int>();

            foreach (string s in parts)
            {
                int result;
                if (!int.TryParse(s, out result))
                {
                    throw new ArgumentException("input");
                }

                numbers.Add(result);    
            }

            numbers.Sort();


            return ConvertToString(numbers);
        }

        private static string ConvertToString(IReadOnlyList<int> numbers)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                output.Append(numbers[i]);
                if (i < numbers.Count - 1)
                {
                    output.Append(", ");
                }
            }

            return output.ToString();
        }
    }
}
