using System;
using Util;

namespace _10_Int_TysonPairs
{
    class Program
    {
        // Not only does 12+1=11+2, but the letters "twelve plus one" rearrange to give you 
        // "eleven plus two"

        // Your task is to write a program that finds equations similar to Tyson's that form 
        // anagrams both in their symbols and in their letters.
        // This solution suggests running to a max of 50:
        // https://www.reddit.com/r/dailyprogrammer/comments/pv8zm/2182012_challenge_10_intermediate/c5axt8z/
        static void Main(string[] args)
        {
            var checker = new TysonPairChecker();
            const int max = 10;

            for (var first = 0; first < max; first++)
            {
                for (var second = 0; second < max; second++)
                {
                    for (var third = 0; third < max; third++)
                    {
                        for (var fourth = 0; fourth < max; fourth++)
                        {
                            var firstStr = string.Format("{0} + {1}", first, second);
                            var secondStr = string.Format("{0} + {1}", third, fourth);

                            if (checker.IsPair(firstStr, secondStr))
                            {
                                Console.WriteLine("{0} equals {1}", firstStr, secondStr);
                            }
                        }
                    }
                }
            }

            ConsoleUtils.WaitForEscape();
        }
    }
}
