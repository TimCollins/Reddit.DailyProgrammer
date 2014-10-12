using System;
using Util;
namespace _1_Diff_Guesser
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pii6j/difficult_challenge_1/
    /// we all know the classic "guessing game" with higher or lower prompts. lets do a role reversal; you create a program that will guess numbers between 1-100, and respond appropriately based on whether users say that the number is too high or too low. Try to make a program that can guess your number based on user input and great code!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();

            DoGuess(1, 100, 1);

            ConsoleUtils.WaitForEscape();
            return;


            char input = ' ';
            int guess;
            int low = 0;
            int high = 100;
            int guesses = 0;

            while (input != 'e')
            {
                guess = (low + high) / 2;
                Console.WriteLine("Is your number (h)igher than, (l)ower than or (e)qual to {0}?", guess);
                DisplayPrompt();

                ConsoleKeyInfo cki = Console.ReadKey(true);
                input = cki.KeyChar;

                switch (input)
                {
                    case 'h':
                        low = guess;
                        break;
                    case 'l':
                        high = guess;
                        break;
                }

                guesses++;
            }

            DisplayEndText(guesses);
            ConsoleUtils.WaitForEscape();
        }

        private static void DoGuess(int low, int high, int turns)
        {
            char input = ' ';
            int guess = (low + high) / 2;
            Console.WriteLine("Is your number (h)igher than, (l)ower than or (e)qual to {0}?", guess);

            ConsoleKeyInfo cki = Console.ReadKey(true);
            input = cki.KeyChar;

            switch (input)
            {
                case 'h':
                    DoGuess(guess, high, turns++);
                    break;
                case 'l':
                    DoGuess(low, guess, turns++);
                    break;
            }
        }

        private static void DisplayEndText(int guesses)
        {
            //Console.WriteLine("Guessed the correct number in {0} turns.", NumberGuesser.NoGuesses);
            Console.WriteLine("Guessed the correct number in {0} turns.", guesses);
        }

        private static void DisplayStartText()
        {
            Console.WriteLine("This program will try to guess a number between {0} and {1} that you pick.", Constants.RangeMin, Constants.RangeMax);
        }

        private static void DisplayPrompt()
        {
            Console.Write("> ");
        }
    }
}
