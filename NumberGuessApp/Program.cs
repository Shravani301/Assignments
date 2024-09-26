using NumberGuessApp.Models;

namespace NumberGuessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGuessingGame game = new NumberGuessingGame();

            Console.WriteLine("Welcome to Guess Number Game");

            string playAgain;
            do
            {
                PlayGame(game);
                Console.Write("Do you want to play again? (y/n): ");
                playAgain = Console.ReadLine() ?? string.Empty;

                if (playAgain.ToLower() == "y")
                {
                    game.ResetGame();
                }

            } while (playAgain.ToLower() == "y");

            Console.WriteLine("Thanks for playing!");
        }

        private static void PlayGame(NumberGuessingGame game)
        {
            Console.WriteLine("You Will Be Asked To Guess A Number To Win The Game");
            int guess;
            int result;

            do
            {
                Console.Write("Enter a guess number between 1 to 100: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    result = game.GuessNumber(guess);

                    if (result == -1)
                    {
                        Console.WriteLine("Oops! Sorry, too low.");
                    }
                    else if (result == 1)
                    {
                        Console.WriteLine("Oops! Sorry, too high.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Yayyy! Your guessed number is correct. You took {game.GetTries()} tries!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    result = -1;
                }
            } while (result != 0);
        }
    }
}
