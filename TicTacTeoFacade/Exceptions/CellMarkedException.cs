using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoFacade.Exceptions
{
    internal class CellMarkedException :Exception
    {
        public CellMarkedException(string message):base(message) { }
    }
}
