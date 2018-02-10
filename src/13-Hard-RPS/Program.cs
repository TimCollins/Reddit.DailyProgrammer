using Util;

namespace _13_Hard_RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a rock - paper - scissors program, however, there should be no user 
            // input. The computer should play against itself. Make the program keep score, 
            // and for extra credit, give the option to "weigh" the chances, so one AI will 
            // win more often.

            var rps = new RockPaperScissors(100);
            rps.Play();
            ConsoleUtils.WaitForEscape();
        }
    }
}
