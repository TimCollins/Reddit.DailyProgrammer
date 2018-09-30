using System;
using Util;

namespace _14_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new BlockProcessor();
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var output = processor.DoSort(input, 3);

            Console.WriteLine("Output is {0}", string.Join(", ", output));
            ConsoleUtils.WaitForEscape();
        }
    }
}
