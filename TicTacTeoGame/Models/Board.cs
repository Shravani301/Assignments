using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoGame.Models
{
    internal class Board
    {
        private readonly char[,] board;
        private int moveCount;

        public Board()
        {
            board = new char[3, 3];
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            moveCount = 0;
        }

        public bool PlaceMark(BoardPosition position, Player player)
        {
            if (position.IsValid() && IsEmpty(position))
            {
                board[position.Row, position.Col] = player.Symbol;
                moveCount++;
                return true;
            }
            return false;
        }

        public bool IsWinner(Player player)
        {
            return HasRowWin(player) || HasColumnWin(player) || HasDiagonalWin(player);
        }

        public bool IsDraw()
        {
            return moveCount == 9;
        }

        public char[,] GetBoard()
        {
            return board;
        }

        private bool IsEmpty(BoardPosition position)
        {
            return board[position.Row, position.Col] == ' ';
        }

        private bool HasRowWin(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player.Symbol && board[i, 1] == player.Symbol && board[i, 2] == player.Symbol)
                    return true;
            }
            return false;
        }

        private bool HasColumnWin(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == player.Symbol && board[1, i] == player.Symbol && board[2, i] == player.Symbol)
                    return true;
            }
            return false;
        }

        private bool HasDiagonalWin(Player player)
        {
            return (board[0, 0] == player.Symbol && board[1, 1] == player.Symbol && board[2, 2] == player.Symbol) ||
                   (board[0, 2] == player.Symbol && board[1, 1] == player.Symbol && board[2, 0] == player.Symbol);
        }
    }
}
