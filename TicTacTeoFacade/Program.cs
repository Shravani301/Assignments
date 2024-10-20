namespace TicTacTeoFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);

            Game game = new Game(player1, player2);
            game.Start();
        }
    }
}
