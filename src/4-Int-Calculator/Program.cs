using System;
using Util;

namespace _4_Int_Calculator
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pm6sq/2122012_challenge_4_intermediate/
    /// Create a calculator program that will take an input, following normal calculator 
    /// input (5 * 5 + 4) and give an answer (29). This calculator should use all four operators.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();
            Console.Write("Please enter the expression to evaluate: ");
            string input = Console.ReadLine();

            int result = Calculator.Calculate(input);

            Console.WriteLine("Result: {0}", result);

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayStartText()
        {
            Console.WriteLine("This program will take a mathematical expression string and evaluate it.");
        }
    }
}
