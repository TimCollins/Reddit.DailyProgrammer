using System;
using Util;

namespace _2_Easy_Calculator
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pjbj8/easy_challenge_2/
    /// ...Your challenge for today is to create a calculator application that has use in 
    /// your life.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();

            Console.Write("Enter start date in dd/mm/yyyy format: ");
            string start = Console.ReadLine();

            Console.Write("Enter end date in dd/mm/yyyy format: ");
            string end = Console.ReadLine();

            // For testing
            //string start = "03/10/2014";
            //string end = "06/10/2014";
            
            DateTime startDate = DateCalculator.GetDateFromString(start);
            DateTime endDate = DateCalculator.GetDateFromString(end);

            int workingDays = DateCalculator.GetWorkingDays(startDate, endDate);

            Console.WriteLine("There are {0} working days between {1} and {2}.", workingDays, start, end);

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayStartText()
        {
            Console.WriteLine("This program will calculate the number of working days between two given dates.");
        }
    }
}
