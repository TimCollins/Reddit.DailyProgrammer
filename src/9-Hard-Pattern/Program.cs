using System;
using Util;

namespace _9_Hard_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterations = 40;
            var result = PatternGenerator.Calculate(iterations);

            Console.WriteLine("Result for {0} iterations is {1}", iterations, result);
            ConsoleUtils.WaitForEscape();
        }
    }
}
