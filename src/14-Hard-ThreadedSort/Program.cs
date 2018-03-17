using Util;

namespace _14_Hard_ThreadedSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will generate a random array / collection of 
            // 1 million integers, then sort them using a multi-threaded algorithm.
            //Your program should take the number of threads through standard input.
            //Bonus points if you can find the most efficient number of threads for your program.

            // Also look for the max number
            var ts = new ThreadedSort();
            ts.Generate();
            ts.Display();
            ts.Sort();
            ts.Display();

            ConsoleUtils.WaitForEscape();
        }
    }
}
