using System;
using Util;

namespace _12_Easy_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to list permutations of\n> ");
            var word = Console.ReadLine();
            WordPermutation("", word);

            ConsoleUtils.WaitForEscape();
        }

        static void WordPermutation(string prefix, string word)
        {
            var n = word.Length;
            if (n == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (var i = 0; i < n; i++)
                {
                    WordPermutation(prefix + word[i], word.Substring(0, i) + word.Substring(i + 1, n - (i + 1)));
                }
            }
        }
    }
}
