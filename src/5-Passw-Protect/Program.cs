using System;
using System.Text;
using Util;

namespace _5_Passw_Protect
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pnhyn/2122012_challenge_5_easy/
    /// Your challenge for today is to create a program which is password protected, and won't 
    /// open unless the correct user and password is given. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");

            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (cki.Key != ConsoleKey.Enter)
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    password.Append(cki.Key);
                }
                else
                {
                    password.Append(cki.Key.ToString().ToLower());
                }
            }

            bool isValid = PasswordChecker.Validate(username, password.ToString());

            Console.WriteLine(isValid ? "Details were valid." : "Invalid username or password entered. Please try again.");

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This program requires a valid username and password.");
        }
    }
}
