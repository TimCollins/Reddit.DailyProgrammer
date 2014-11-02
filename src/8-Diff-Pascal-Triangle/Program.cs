using Util;

namespace _8_Diff_Pascal_Triangle
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/psf4n/2162012_challenge_8_difficult/
    /// Write a program that will take coordinates, and tell you the corresponding number in 
    /// Pascal's Triangle.
    /// See also http://en.wikipedia.org/wiki/Pascal%27s_triangle
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            PascalTriangleCalculator.ShowPascal(15);
            ConsoleUtils.WaitForEscape();
        }
    }
}
