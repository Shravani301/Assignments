using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacTeoFacade
{
    internal class Player
    {
        MarkType type;
       
        public Player(MarkType mark)
        { 
            type = mark;
        }
        public void PlayGame(Board board)
        {
            Console.WriteLine("Choose your position :"+type);
            int position = Convert.ToInt32(Console.ReadLine());
            board.SetCellMark(position, type);
        }
    }
}
