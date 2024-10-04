using MovieAppLayers.Controller;
using MovieAppLayers.Presentation;

namespace MovieAppLayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager manager=new MovieManager();
            MovieMenu.DisplayMenu();
        }
    }
}
