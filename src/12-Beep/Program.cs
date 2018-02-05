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
                return;
            }

            try
            {
                new NotePlayer().Play(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem playing the specified notes");
                Console.WriteLine(ex.Message);
            }
            
            ConsoleUtils.WaitForEscape();
        }
    }
}
