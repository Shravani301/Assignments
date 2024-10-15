using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoGame.Models
{
    internal class BoardPosition
    {
        public int Row { get; }
        public int Col { get; }

        public BoardPosition(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public bool IsValid()
        {
            return Row >= 0 && Row < 3 && Col >= 0 && Col < 3;
        }
    }
}
