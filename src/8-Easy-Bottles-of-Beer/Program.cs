using System;
using Util;

namespace _8_Easy_Bottles_of_Beer
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pserp/2162012_challenge_8_easy/
    /// Write a program that will print the song "99 bottles of beer on the wall".
    /// Lyrics taken from http://99-bottles-of-beer.net/lyrics.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = 99;

            while (bottles > -1)
            {
                Console.WriteLine(SongPrinter.PrintVerse(bottles));
                bottles--;
            }
            ConsoleUtils.WaitForEscape();
        }
    }
}
