using Util;

namespace _6_Int_Remove_Dup
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pp81n/2142012_challenge_6_intermediate/
    /// Remove duplicate substrings from input
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string output = DuplicateRemover.Remove("aaatestBlaBlatestBlaBla");
            ConsoleUtils.WaitForEscape();
        }
    }
}
