using System;
using System.Collections.Generic;
using Util;

namespace _4_Easy_Password
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pm6oj/2122012_challenge_4_easy/
    /// Your challenge for today is to create a random password generator!
    /// For extra credit, allow the user to specify the amount of passwords to generate.
    /// For even more extra credit, allow the user to specify the length of the strings he 
    /// wants to generate!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();
            Console.Write("Please enter the number of passwords to generate: ");
            int noPasswords = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the length of each password: ");
            int passwordLength = Convert.ToInt32(Console.ReadLine());

            List<string> passwords = PasswordGenerator.GeneratePasswords(noPasswords, passwordLength);

            DisplayPasswords(passwords);

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayPasswords(List<string> passwords)
        {
            for (int i = 0; i < passwords.Count; i++)
            {
                Console.WriteLine("Password {0}: {1}", i + 1, passwords[i]);
            }
        }

        private static void DisplayStartText()
        {
            Console.WriteLine("This is a password generator.");
        }
    }
}
