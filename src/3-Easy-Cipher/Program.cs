using System;
using Util;

namespace _3_Easy_Cipher
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pkw2m/2112012_challenge_3_easy/
    /// Write a program that can encrypt texts with an alphabetical caesar cipher. This 
    /// cipher can ignore numbers, symbols, and whitespace.
    /// For extra credit, add a "decrypt" function to your program!
    /// http://en.wikipedia.org/wiki/Caesar_cipher
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();

            Console.Write("Please enter some text: ");
            string input = Console.ReadLine();
            
            // For testing
            //string input = "fred";

            Console.Write("Encrypted text: ");
            string encrypted = Cipher.Encrypt(input);
            Console.WriteLine(encrypted);

            Console.Write("Decrypted text: ");
            Console.WriteLine(Cipher.Decrypt(encrypted));

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This is an implementation of a Caesar cipher.");
        }
    }
}
