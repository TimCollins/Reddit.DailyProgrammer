using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4_Diff_NumCombos
{
    public class NumCombo
    {
        public static List<int> ParseInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException(input);
            }

            // Take a string like 2,3,4
            // and return a list of just the integers.
            input = Regex.Replace(input, @"\s+", "");

            string[] numbers = input.Split(',');

            List<int> output = new List<int>();

            foreach (string s in numbers)
            {
                output.Add(Convert.ToInt32(s));
            }
            
            return output;
        }

        public static List<string> FindRelations(List<int> numbers)
        {
            // Given a list of numbers
            // return a set of strings showing how the numbers are related
            // e.g. (5, 3, 15) should return "5 * 3 = 15", "15 / 3 = 5", "15 / 5 = 15"
            return null;
        }
    }
}
