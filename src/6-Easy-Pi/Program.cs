using System;
using Util;

namespace _6_Easy_Pi
{
    /// <summary>
    /// From http://www.reddit.com/r/dailyprogrammer/comments/pp53w/2142012_challenge_6_easy/
    /// Calculate pi accurately to at least 30 decimal places. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // This will give 3.14285714285714 which is 15 digits.
            //const double output = (double) 22 / 7;
            //Console.WriteLine("Pi = {0}", output);

            // This will only allow a digits parameter of up to 15 (inclusive).
            //Math.Round(Math.PI, 15)

            
            Console.WriteLine("Pi = {0}", BigMath.GetPi(30, 5));
            ConsoleUtils.WaitForEscape();
        }
    }
}
