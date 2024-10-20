using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoFacade.Exceptions
{
    internal class CellNumberExceededException:Exception
    {
        public CellNumberExceededException(string message):base(message) { }
    }
}
