using System;

namespace _13_Hard_RPS
{
    public class RockPaperScissors
    {
        private readonly int _maxGames;
        private readonly Random _rand;

        public RockPaperScissors()
        {
            _maxGames = 100;
            _rand = new Random();
        }

        /// <summary>
        /// Initialise a new instance of the class
        /// </summary>
        /// <param name="maxGames">The maximum number of games to play</param>
        public RockPaperScissors(int maxGames)
        {
            _maxGames = maxGames;
            _rand = new Random();
        }

        public void Play()
        {
            var counter = 0;

            while (counter != _maxGames)
            {
                var p1Guess = Choose();
                var p2Guess = Choose();
                var result = Evaluate(p1Guess, p2Guess);
                var resultStr = Parse(result);

                Console.WriteLine("P1: {0}\tP2: {1}\tResult: {2}", p1Guess, p2Guess, resultStr);
                counter++;
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
