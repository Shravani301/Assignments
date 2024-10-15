using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTeoGame.Models;

namespace TicTacTeoGame.Presentation
{
    internal class Menu
    {
        public void DisplayBoard(Board board)
        {
            char[,] boardState = board.GetBoard();
            Console.Clear();
            Console.WriteLine("  0   1   2 ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i} {boardState[i, 0]} | {boardState[i, 1]} | {boardState[i, 2]} ");
                if (i < 2)
                    Console.WriteLine(" ---|---|---");
            }
        }

        public BoardPosition GetPlayerInput(Player player)
        {
            Console.WriteLine($"Player {player.Symbol}'s turn. Enter row and column (e.g., 0 1):");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            return new BoardPosition(row, col);
        }

        public void AnnounceWinner(Player player)
        {
            Console.WriteLine($"Player {player.Symbol} wins!");
        }

        public void AnnounceDraw()
        {
            Console.WriteLine("The game is a draw!");
        }

        public bool AskPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string playAgain = Console.ReadLine();
            return playAgain.ToLower() == "y";
        }

    }
}
