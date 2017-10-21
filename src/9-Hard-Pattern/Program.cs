using System;
using Util;

namespace _9_Hard_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 40;
            string output = PatternGenerator.Calculate(max);

            Console.WriteLine("Iteration {0} is {1}", max, output);
            ConsoleUtils.WaitForEscape();
        }
    }
}
