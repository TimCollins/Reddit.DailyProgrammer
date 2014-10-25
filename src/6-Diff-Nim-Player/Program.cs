using System;
using Util;

namespace _6_Diff_Nim_Player
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pp7vo/2142012_challenge_6_difficult/
    /// Create an AI that will play NIM (http://en.wikipedia.org/wiki/Nim).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();

            Init();
            
            bool done = false;

            while (!done)
            {
                if (NimPlayer.HeapsEmpty())
                {
                    done = true;
                }
            }

            ConsoleUtils.WaitForEscape();
        }

        private static void Init()
        {
            NimPlayer.HeapA = 3;
            NimPlayer.HeapB = 4;
            NimPlayer.HeapC = 5;
        }


        private static void DisplayStartText()
        {
            Console.WriteLine("This program will play Nim.");
        }
    }
}
