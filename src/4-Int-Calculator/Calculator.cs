using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _4_Int_Calculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            // Assume that input strings are going to consist of integers and operators only.
            // e.g. (5*5+4)
            // First and last chars will always be numbers.
            Regex.Replace(input, @"\s+", "");

            List<int> numbers = new List<int>();
            List<char> operators = new List<char>();
            ParseInput(input, numbers, operators);

            return Evaluate(numbers, operators);
        }

        private static int Evaluate(List<int> numbers, List<char> operators)
        {
            // Check the first number and the first operator.
            // If the first operator is + or - and the second operator is / or * then the third
            // number should be used in the * or / expression with the second number 
            // and then the first operator and number with the result.

            char firstOp = operators[0];
            char? secondOp = operators.Count > 1 ? operators[1] : (char?) null;
            int first = numbers[0];
            int second = numbers[1];
            int? third = numbers.Count > 2 ? numbers[2] : (int?) null;
            int part1 = 0;
            int part2 = 0;

            if (LowPrecedence(firstOp) && HighPrecedence(secondOp))
            {
                part2 = GetResult(second, third.Value, secondOp.Value);
                part1 = GetResult(first, part2, firstOp);

                return part1;
            }
            else
            {
                part1 = GetResult(first, second, firstOp);
                part2 = third.HasValue && secondOp.HasValue
                    ? GetResult(part1, third.Value, secondOp.Value) 
                    : 0;

                return part2 == 0 
                    ? part1 + part2 
                    : part2;
            }
        }

        private static int GetResult(int first, int second, char op)
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

        private static bool HighPrecedence(char? op)
        {
            return op.HasValue && (op == '*' || op == '/');
        }

        private static bool LowPrecedence(char op)
        {
            return op == '+' || op == '-';
        }

        private static void ParseInput(string input, List<int> numbers, List<char> operators)
        {
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    numbers.Add(Convert.ToInt32(c - 48));
                }
                else if (IsOperator(c))
                {
                    operators.Add(c);
                }
            }
        }

        private static bool IsOperator(char c)
        {
            return "+-/*".Contains(c.ToString());
        }
    }
}
