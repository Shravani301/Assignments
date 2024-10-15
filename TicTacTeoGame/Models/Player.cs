using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoGame.Models
{
    internal class Player
    {
        public char Symbol { get; }

        public Player(char symbol)
        {
            Symbol = symbol;
        }

        public Player SwitchPlayer()
        {
            return Symbol == 'X' ? new Player('O') : new Player('X');
        }
    }
}
