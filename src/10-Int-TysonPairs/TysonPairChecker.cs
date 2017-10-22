using System;
using System.Collections.Generic;

namespace _10_Int_TysonPairs
{
    public class TysonPairChecker
    {
        public bool IsPair(string first, string second)
        {
            // A pair of equations is considered a Tyson pair if the following conditions are 
            // true:
            // 1. the arithmetic operations produce the same value 
            // 2. the English representation of the numbers are anagrams of each other
            // For example, "12 + 1" == "11 + 2" and 
            // "twelve plus one" is an anagram of "eleven plus two"
            // Only '+' is supported as an arithmetic operator

            // Split the strings into their arithmetic components
            // Calculate the value of each one
            // If the values don't match then return false - this can be an initial unit test
            // If the values do match then get the English representation of each number
            // Use the other project for that
            // Check if the first string is an anagram of the second - this can be another test

            var firstNumbers = GetNumbers(first);
            var secondNumbers = GetNumbers(second);

            var firstSum = Sum(firstNumbers);
            var secondSum = Sum(secondNumbers);

            if (firstSum != secondSum)
            {
                return false;
            }

            return true;
        }

        private int Sum(int[] numbers)
        {
            var total = 0;

            foreach (int i in numbers)
            {
                total += i;
            }

            return total;
        }

        private int[] GetNumbers(string input)
        {
            var parts = input.Split('+');
            var numbers = new List<int>();

            foreach (var s in parts)
            {
                numbers.Add(Convert.ToInt32(s.Trim()));
            }

            return numbers.ToArray();
        }
    }
}
