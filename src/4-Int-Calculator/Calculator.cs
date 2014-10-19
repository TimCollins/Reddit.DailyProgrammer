using System;
using System.Text.RegularExpressions;

namespace _4_Int_Calculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            // Assume that input strings are going to consist of integers and operators only.
            Regex.Replace(input, @"\s+", "");

            // Handles things like 1 + 1
            int? first = null;
            char? op = null;
            int? second = null;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    if (!first.HasValue)
                    {
                        first = Convert.ToInt32(c - 48);
                    }
                    else
                    {
                        second = Convert.ToInt32(c - 48);
                    }
                }
                else if (IsOperator(c))
                {
                    op = c;
                }
            }

            // If the input string hasn't been parsed then throw an exception.
            if (!first.HasValue || !op.HasValue || !second.HasValue)
            {
                throw new ArgumentException("input");   
            }

            return Evaluate(first.Value, op.Value, second.Value);
        }

        private static bool IsOperator(char c)
        {
            return "+-/*".Contains(c.ToString());
        }

        private static int Evaluate(int first, char op, int second)
        {
            switch (op)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '*':
                    return first * second;
                case '/':
                    return first / second;
            }
            throw new ArgumentException("op");
        }
    }
}
