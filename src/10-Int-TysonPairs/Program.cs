using System;
using Util;
using _8_Int_Numbers_To_English;

namespace _10_Int_TysonPairs
{
    class Program
    {
        // Not only does 12+1=11+2, but the letters "twelve plus one" rearrange to give you 
        // "eleven plus two"

        // Your task is to write a program that finds equations similar to Tyson's that form 
        // anagrams both in their symbols and in their letters.
        static void Main(string[] args)
        {
            var checker = new TysonPairChecker();

            for (var i = 1; i < 51; i++)
            {
                for (var j = 1; j < 51; j++)
                {
                    if (checker.IsPair(i, j))
                    {
                        Console.WriteLine(FormatOutput(i, j));
                    }
                }
            }
            var output = NumberConverter.Convert(50);
            Console.WriteLine(output);
            ConsoleUtils.WaitForEscape();
        }

        private static string FormatOutput(int first, int second)
        {
            NumberConverter.Convert(50);
            return string.Empty;
        }
    }
}
