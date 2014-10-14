using System;
using Util;

namespace _2_Int_Adventure
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pjbuj/intermediate_challenge_2/
    /// A simple text adventure.
    /// </summary>
    class Program
    {
        private static readonly Random _random = new Random();

        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();
            int kills = 0;
            bool isAlive = true;

            while (isAlive)
            {
                Console.WriteLine("{0}, a monster has arrived!", name);
                char input = ' ';
                while (input != 'a')
                {
                    DisplayMenu();
                    DisplayPrompt();

                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    input = cki.KeyChar;
                }

                // The user has a 75% chance of killing a monster if they attack.
                if (input == 'a')
                {
                    int r = _random.Next(1, 101);
                    if (r > 75)
                    {
                        isAlive = false;
                    }
                    else
                    {
                        kills++;
                        Console.WriteLine("You kill the monster.");
                    }
                }
            }

            Console.WriteLine("You have died but you took {0} monsters with you.", kills);

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("(A)ttack\n" +
                              "(R)un");
        }

        private static void DisplayPrompt()
        {
            Console.Write("> ");
        }
    }
}
