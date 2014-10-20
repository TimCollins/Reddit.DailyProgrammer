using System;
using System.Collections.Generic;
using Util;

namespace _4_Diff_NumCombos
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pm7g7/2122012_challange_4_difficult/
    /// Create a program that will take a series of numbers (5, 3, 15), and find how those numbers 
    /// can add, subtract, multiply, or divide in various ways to relate to each other.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();

            Console.Write("Please enter some comma-separated numbers: ");
            string input = Console.ReadLine();
            List<int> numbers = NumCombo.ParseInput(input);
            List<string> output = NumCombo.FindRelations(numbers);

            ShowOutput(numbers, output);
            ConsoleUtils.WaitForEscape();
        }

        private static void ShowOutput(List<int> numbers, List<string> output)
        {
            Console.WriteLine("The input was ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write("{0}", numbers[i]);
                Console.Write(i < numbers.Count - 1 ? ", " : "");
            }

            Console.WriteLine("The output is ");
            foreach (string s in output)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This program will take a series of numbers and show how " +
                "those numbers relate to each other.");
        }
    }
}
