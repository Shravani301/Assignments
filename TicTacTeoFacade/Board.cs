using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTeoFacade.Exceptions;

namespace TicTacTeoFacade
{
    internal class Board
    {
        Cell[] cells;
        public Board() 
        {
            cells = new Cell[9];
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Cell();
                cells[i].SetMark(MarkType.EMPTY);
            }
        }
        public bool IsBoardFull()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].GetMark() == MarkType.EMPTY)
                    return false;

            }
            return true;
        }

        public void SetCellMark(int position, MarkType mark)
        {
            if (position < 0 || position >= cells.Length)
                throw new CellNumberExceededException("Please position between 0-8");
            if (cells[position].GetMark() == MarkType.EMPTY)
                cells[position].SetMark(mark);
            else
                throw new CellMarkedException("Cell is already occupied");
        }
        public MarkType GetCellMark(int position)
        {
            return cells[position].GetMark();
        }

    }
}
