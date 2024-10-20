using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoFacade
{
    internal class ResultAnalyzer
    {
        private Board board;

        public ResultAnalyzer(Board board)
        {
            this.board = board;
        }

        public bool CheckAll()
        {
            return CheckFirstRow() || CheckSecondRow() || CheckThirdRow() ||
                   CheckFirstColumn() || CheckSecondColumn() || CheckThirdColumn() ||
                   CheckLeftDiagonal() || CheckRightDiagonal();
        }

        private bool CheckFirstRow()
        {
            return board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2) && board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckSecondRow()
        {
            return board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5) && board.GetCellMark(3) != MarkType.EMPTY;
        }

        private bool CheckThirdRow()
        {
            return board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8) && board.GetCellMark(6) != MarkType.EMPTY;
        }

        private bool CheckFirstColumn()
        {
            return board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6) && board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckSecondColumn()
        {
            return board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7) && board.GetCellMark(1) != MarkType.EMPTY;
        }

        private bool CheckThirdColumn()
        {
            return board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8) && board.GetCellMark(2) != MarkType.EMPTY;
        }

        private bool CheckLeftDiagonal()
        {
            return board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8) && board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckRightDiagonal()
        {
            return board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6) && board.GetCellMark(2) != MarkType.EMPTY;
        }
    }
}
