using System;
using System.Text;

namespace _13_Hard_RPS
{
    public class RockPaperScissors
    {
        private readonly int _maxGames;
        private readonly Random _rand;
        private int _draws;
        private int _p1Wins;
        private int _p2Wins;


        public RockPaperScissors()
        {
            _maxGames = 100;
            _rand = new Random();

            InitialiseProperties();
        }

        private void InitialiseProperties()
        {
            _draws = 0;
            _p1Wins = 0;
            _p2Wins = 0;
        }

        /// <summary>
        /// Initialise a new instance of the class
        /// </summary>
        /// <param name="maxGames">The maximum number of games to play</param>
        public RockPaperScissors(int maxGames)
        {
            _maxGames = maxGames;
            _rand = new Random();

            InitialiseProperties();
        }

        public void Play()
        {
            var counter = 0;

            while (counter != _maxGames)
            {
                var p1Guess = Choose();
                var p2Guess = Choose();
                var result = Evaluate(p1Guess, p2Guess);
                UpdateStats(result);
                var resultStr = Parse(result);

                Console.WriteLine("P1: {0}\tP2: {1}\tResult: {2}", p1Guess, p2Guess, resultStr);
                counter++;
            }

            DisplayStats();
        }

        private void DisplayStats()
        {
            var output = new StringBuilder();
            var drawPercentage = (double) _draws / _maxGames * 100;
            var p1Percentage = (double) _p1Wins / _maxGames * 100;
            var p2Percentage = (double) _p2Wins / _maxGames * 100;

            output.Append("Rock Paper Scissors Statistics\n");
            output.Append(string.Format("Total games played: {0}\n", _maxGames));
            output.Append(string.Format("Player 1 wins: {0} ({1})%\n", _p1Wins, p1Percentage));
            output.Append(string.Format("Player 2 wins: {0} ({1})%\n", _p2Wins, p2Percentage));
            output.Append(string.Format("Draws: {0} ({1})%", _draws, drawPercentage));

            Console.WriteLine(output.ToString());
        }

        private void UpdateStats(string result)
        {
            if (result == "draw")
            {
                _draws++;
            }

            if (result == "p1")
            {
                _p1Wins++;
            }

            if (result == "p2")
            {
                _p2Wins++;
            }
        }

        private string Parse(string input)
        {
            if (input == "p1")
            {
                return "Player 1 wins";
            }

            if (input == "p2")
            {
                return "Player 2 wins";
            }

            return "Draw";
        }

        private string Evaluate(string p1Guess, string p2Guess)
        {
            //Console.WriteLine("P1: {0}\tP2: {1}", p1Guess, p2Guess);

            if (p1Guess == p2Guess)
            {
                return "draw";
            }

            if (p1Guess == "Rock")
            {
                if (p2Guess == "Paper")
                {
                    return "p2";
                }
                if (p2Guess == "Scissors")
                {
                    return "p1";
                }
            }

            if (p1Guess == "Paper")
            {
                if (p2Guess == "Rock")
                {
                    return "p1";
                }

                if (p2Guess == "Scissors")
                {
                    return "p2";
                }
            }

            if (p1Guess == "Scissors")
            {
                if (p2Guess == "Rock")
                {
                    return "p2";
                }

                if (p2Guess == "Paper")
                {
                    return "p1";
                }
            }

            throw new ApplicationException(string.Format("Error parsing guesses. P1: {0}, P2: {1}", p1Guess, p2Guess));
        }

        private string Choose()
        {
            string[] plays =
            {
                "Rock",
                "Paper",
                "Scissors"
            };

            var choice = _rand.Next(0, 3);
            return plays[choice];
        }
    }
}
