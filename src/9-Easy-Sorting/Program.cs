using System;
using Util;

namespace _9_Easy_Sorting
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pu1rf/2172012_challenge_9_easy/
    /// Write a program that will allow the user to input digits, and arrange them in numerical 
    /// order.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string userInput = Console.ReadLine();

            string output = Sorter.Sort(userInput);

            Console.WriteLine("Sorted: " + output);

            ConsoleUtils.WaitForEscape();
        }
    }
}
