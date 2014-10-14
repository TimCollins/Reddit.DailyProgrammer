using System;
using Util;

namespace _2_Diff_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (!done)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    done = true;

                Console.WriteLine("something...");
            }


            ConsoleUtils.WaitForEscape();
        }
    }
}
