using System;

namespace PigDice.Models
{
    internal class PigGame
    {
        public int CurrentTurnScore { get; private set; }
        public int TotalScore { get; private set; }
        public int TurnNumber { get; private set; } // New property to track turn number
        public bool IsGameOver { get; private set; }

        private const int WinningScore = 20;
        private Random dice;

        public PigGame()
        {
            CurrentTurnScore = 0;
            TotalScore = 0;
            TurnNumber = 1; // Initialize the turn number
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
                IncrementTurn();
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
            TotalScore += CurrentTurnScore; // Add current turn score to total score
            EndTurn(); // Reset current turn score for the next turn
            Console.WriteLine("You held. Your total score is now: " + TotalScore);

            if (TotalScore >= WinningScore)
            {
                EndGame();
                Console.WriteLine("Congratulations! You reached the winning score.");
            }
            else
            {
                IncrementTurn(); // Increment turn number for the next turn
            }
        }


        private void EndTurn()
        {
            CurrentTurnScore = 0;
        }

        private void IncrementTurn()
        {
            TurnNumber++; // Increment turn number
            CurrentTurnScore = 0; // Reset current turn score for the new turn
            Console.WriteLine($"Starting turn number {TurnNumber}!");
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
