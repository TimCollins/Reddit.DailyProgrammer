using System;
using Util;

namespace _13_Int_Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take a string from the command-line
            // Reverse it
            // Write it out to reverse.txt
            var reverser = new Reverser();
            if (!reverser.IsValidCommandLine(args))
            {
                Console.WriteLine("Invalid command line.\nPlease specify a line of text to reverse.");
                return;
            }

            var output = reverser.Reverse(args[0]);
            reverser.Write(output);

            Console.WriteLine("Reversed string written!");
            ConsoleUtils.WaitForEscape();
        }
    }
}
