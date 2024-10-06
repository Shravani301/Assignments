using PigDice.Models;
using System;

namespace PigDice.Controller
{
    internal class PigGameManager
    {
        private PigGame pigGame;

        public PigGameManager()
        {
            pigGame = new PigGame();
        }

        public void Roll()
        {
            if (!pigGame.IsGameOver)
            {
                pigGame.RollDice();
            }
        }

        public void Hold()
        {
            if (!pigGame.IsGameOver)
            {
                pigGame.Hold();
            }
        }

        public void DisplayCurrentState()
        {
            Console.WriteLine($"Current turn score: {pigGame.CurrentTurnScore}, Total score: {pigGame.TotalScore}");
        }

        public void ResetGame()
        {
            pigGame = new PigGame();
            Console.WriteLine("Game has been reset.");
        }

        public void QuitGame()
        {
            pigGame.QuitGame();
        }

        public bool IsGameOver()
        {
            return pigGame.IsGameOver;
        }

        public int GetCurrentTurnScore()
        {
            return pigGame.CurrentTurnScore;
        }

        public int GetTotalScore()
        {
            return pigGame.TotalScore;
        }
    }
}
