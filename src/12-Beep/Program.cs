using System;
using Util;

namespace _12_Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("You must enter some notes!");
            }
            
            new NotePlayer().Play(args);
            ConsoleUtils.WaitForEscape();
        }
    }
}
