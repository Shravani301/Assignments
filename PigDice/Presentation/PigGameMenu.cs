using PigDice.Controller;
using System;

namespace PigDice.Presentation
{
    internal class PigGameMenu
    {
        private PigGameManager pigGameManager;

        public PigGameMenu()
        {
            pigGameManager = new PigGameManager();
        }

        public void DisplayMenu()
        {
            while (!pigGameManager.IsGameOver())
            {
                Console.WriteLine("\nCurrent turn score: " + pigGameManager.GetCurrentTurnScore() + ", Total score: " + pigGameManager.GetTotalScore());
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("r: Roll the dice");
                Console.WriteLine("h: Hold");
                Console.WriteLine("d: Display Current Score");
                Console.WriteLine("c: Reset Game");
                Console.WriteLine("q: Quit");

                string choice = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(choice))
                {
                    PerformAction(choice);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (r, h, d, etc.).");
                }
            }

            Console.WriteLine("Game Over!");
        }

        private void PerformAction(string choice)
        {
            switch (choice)
            {
                case "r":
                    pigGameManager.Roll();
                    break;
                case "h":
                    pigGameManager.Hold();
                    break;
                case "d":
                    pigGameManager.DisplayCurrentState();
                    break;
                case "c":
                    pigGameManager.ResetGame();
                    break;
                case "q":
                    pigGameManager.QuitGame();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (r, h, d, e, q).");
                    break;
            }
        }
    }
}
