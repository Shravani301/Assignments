using System;

namespace PigDice.Models
{
    internal class PigGame
    {
        public int CurrentTurnScore { get; private set; }
        public int TotalScore { get; private set; }
        public bool IsGameOver { get; private set; }

        private const int WinningScore = 20;
        private Random dice;

        public PigGame()
        {
            CurrentTurnScore = 0;
            TotalScore = 0;
            IsGameOver = false;
            dice = new Random();
        }

        public void RollDice()
        {
            int rolledValue = dice.Next(1, 7);
            Console.WriteLine($"You rolled a {rolledValue}");

            if (rolledValue == 1)
            {
                EndTurn();
                Console.WriteLine("You rolled a 1! Turn over. No points added.");
                return;
            }

            CurrentTurnScore += rolledValue;

            if (TotalScore + CurrentTurnScore >= WinningScore)
            {
                EndGame();
                Console.WriteLine("Congratulations! You reached the winning score.");
            }
        }

        public void Hold()
        {
            TotalScore += CurrentTurnScore;
            CurrentTurnScore = 0;
            Console.WriteLine("You held. Your total score is now: " + TotalScore);

            if (TotalScore >= WinningScore)
            {
                EndGame();
                Console.WriteLine("Congratulations! You reached the winning score.");
            }
        }

        private void EndTurn()
        {
            CurrentTurnScore = 0;
        }

        private void EndGame()
        {
            IsGameOver = true;
        }

        public void QuitGame()
        {
            IsGameOver = true;
            Console.WriteLine("Thanks for playing! Game has been quit.");
        }
    }
}
