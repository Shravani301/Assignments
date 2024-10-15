using TicTacTeoGame.Models;
using TicTacTeoGame.Presentation;

namespace TicTacTeoGame
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            var gameBoard = new Board();
            var menu = new Menu();
            var player = new Player('X');

            PlayGame(gameBoard, menu, player);
            if (menu.AskPlayAgain())
            {
                StartGame();
            }
        }

        static void PlayGame(Board board, Menu menu, Player player)
        {
            while (true)
            {
                menu.DisplayBoard(board);
                var position = menu.GetPlayerInput(player);
                if (!board.PlaceMark(position, player))
                    continue;

                if (board.IsWinner(player))
                {
                    menu.DisplayBoard(board);
                    menu.AnnounceWinner(player);
                    break;
                }

                if (board.IsDraw())
                {
                    menu.DisplayBoard(board);
                    menu.AnnounceDraw();
                    break;
                }

                player = player.SwitchPlayer();
            }
        }
    }
}

