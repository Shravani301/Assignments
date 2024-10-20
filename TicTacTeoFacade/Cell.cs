using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTeoFacade.Exceptions;

namespace TicTacTeoFacade
{
    internal class Cell
    {
        MarkType _mark;
        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
        public bool IsEmpty(Cell cell)
        {
            if(cell._mark == MarkType.EMPTY) 
                return true;
            return false;
        }
        public MarkType GetMark()
        {
            return _mark;   
        }
        public void SetMark(MarkType mark)
        {
            if (_mark == MarkType.EMPTY)
                _mark = mark;
            else
                throw new CellMarkedException("The cell is occupied");
        }

    }
}
