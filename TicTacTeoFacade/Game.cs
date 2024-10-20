using System;
using TicTacTeoFacade.Exceptions;

namespace TicTacTeoFacade
{
    internal class Game
    {
        private Board board;
        private Player player1;
        private Player player2;
        private ResultAnalyzer resultAnalyzer;
        private Player currentPlayer;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            board = new Board();
            resultAnalyzer = new ResultAnalyzer(board);
            currentPlayer = player1;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            PlayRounds();
        }

        private void PlayRounds()
        {
            while (true)
            {
                DisplayBoard();
                HandlePlayerTurn();

                if (IsGameOver()) return;
                SwitchPlayer();
            }
        }

        private void HandlePlayerTurn()
        {
            bool validMove = false;
            while (!validMove)
            {
                try
                {
                    currentPlayer.PlayGame(board);
                    validMove = true;
                }
                catch (CellMarkedException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please select a different cell.");
                }
                catch (CellNumberExceededException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter a position between 0 and 8.");
                }
            }
        }

        private bool IsGameOver()
        {
            if (IsWin())
            {
                AnnounceWinner();
                return true;
            }

            if (IsDraw())
            {
                DisplayBoard();
                Console.WriteLine("The game is a draw!");
                return true;
            }

            return false;
        }

        private bool IsWin()
        {
            return resultAnalyzer.CheckAll();
        }

        private bool IsDraw()
        {
            return board.IsBoardFull();
        }

        private void AnnounceWinner()
        {
            string winner = currentPlayer == player1 ? "Player 1 (X)" : "Player 2 (O)";
            DisplayBoard();
            Console.WriteLine($"{winner} wins!");
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }

        private void DisplayBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                DisplayCell(i);
                if ((i + 1) % 3 == 0) Console.WriteLine();
            }
        }

        private void DisplayCell(int i)
        {
            MarkType mark = board.GetCellMark(i);
            char displayMark = mark == MarkType.EMPTY ? '_' : mark.ToString()[0];
            Console.Write(displayMark + " ");
        }
    }
}
