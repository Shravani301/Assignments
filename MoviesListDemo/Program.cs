using MoviesListDemo.Models;
using MoviesListDemo.Services;
using System.Configuration;

namespace MoviesListDemo
{
    internal class Program
    {
        public static string FilePath = ConfigurationManager.AppSettings["myFile"];
        static void Main(string[] args)
        {

            List<Movie> movies = SerializationMovies.MoviesDeserialize();
            
            while (true)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                HandleOperations(choice,movies);
            }

        }
        private static void HandleOperations(int choice, List<Movie> movies)
        {
            switch (choice)
            {
                case 1:
                    DisplayMovies(movies);
                    break;
                case 2:
                    AddMovie(movies);
                    break;
                case 3:
                    ClearAll(movies);
                    break;
                case 4:
                    SerializationMovies.MoviesSerialization(movies);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ïnvalid Input please enter correct");
                    break;

            }
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Enter your choice to perform Operation");
            Console.WriteLine(" 1. Display Movies\n 2. Add Movie\n 3. Clear All Movies\n 4. Exit");
        }
        public static void DisplayMovies(List<Movie> movies)
        {
            if (movies.Count == 0)
                Console.WriteLine("Please add a Movie");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        public static void AddMovie(List<Movie> movies)
        {
            Console.WriteLine("Enter movie ID");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a movie name:");
            string title = Console.ReadLine()??string.Empty;
            Console.WriteLine("Enter a movie Genre");
            string genre= Console.ReadLine()?? string.Empty;
            Console.WriteLine("Enter a movie release year:");
            int year=Convert.ToInt32(Console.ReadLine());
            movies.Add(new Movie(id, title, genre, year));
        }
        public static void ClearAll(List<Movie> movies)
        {
            
            movies.Clear();
        }
    }
}
