using System;
using System.Collections.Generic;
using System.Linq;
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

            input = Regex.Replace(input, @"\s+", "");

            string[] numbers = input.Split(',');

            List<int> output = new List<int>();
            foreach (string s in numbers)
            {
                int i;
                if (!int.TryParse(s, out i))
                {
                    throw new ArgumentException(input);
                }

                output.Add(i);
            }
            
            return new List<int>(output.OrderBy(x => x));
        }

        public static List<string> FindRelations(List<int> numbers)
        {
            // Given a list of numbers
            // return a set of strings showing how the numbers are related
            // e.g. (5, 3, 15) should return "5 * 3 = 15", "15 / 3 = 5", "15 / 5 = 15"
            List<string> output = new List<string>();

            int a = numbers[0];
            int b = numbers[1];
            int c = numbers[2];
            CheckValues(output, a, b, c);

            a = numbers[1];
            b = numbers[0];
            c = numbers[2];
            CheckValues(output, a, b, c);

            a = numbers[2];
            b = numbers[1];
            c = numbers[0];
            CheckValues(output, a, b, c);

            a = numbers[1];
            b = numbers[2];
            c = numbers[0];
            CheckValues(output, a, b, c);

            a = numbers[2];
            b = numbers[0];
            c = numbers[1];
            CheckValues(output, a, b, c);

            a = numbers[0];
            b = numbers[2];
            c = numbers[1];
            CheckValues(output, a, b, c);

            return output;
        }


        private static void CheckValues(ICollection<string> output, int a, int b, int c)
        {
            if (a + b == c)
            {
                output.Add(string.Format("{0} + {1} = {2}", a, b, c));
            }

            if (a - b == c)
            {
                output.Add(string.Format("{0} - {1} = {2}", a, b, c));
            }

            if (a * b == c)
            {
                output.Add(string.Format("{0} * {1} = {2}", a, b, c));
            }

            if (a / b == c)
            {
                output.Add(string.Format("{0} / {1} = {2}", a, b, c));
            }
        }
    }
}
