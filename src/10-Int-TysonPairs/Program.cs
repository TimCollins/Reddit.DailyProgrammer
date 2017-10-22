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

            ConsoleUtils.WaitForEscape();
        }
    }
}
