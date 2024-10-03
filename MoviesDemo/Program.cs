using MoviesDemo.Models;
using MoviesDemo.Services;
using System.ComponentModel.DataAnnotations;

namespace MoviesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Movie[] movies=
            {
                new Movie(101,"RRR","action",2022),
                new Movie(102,"Parasite","Drama",2019),
                new Movie(103,"Hi Nanna","Drama",2023),
                new Movie(104,"Hi Nanna","Action",2010),
                new Movie(105,"Bahubali","Action",2015)
            };
            Console.WriteLine(SerializationMovies.MoviesSerialization(movies));
            movies= SerializationMovies.MoviesDeserialize();
            Console.WriteLine(movies.Length);
            DisplayMovies(movies);
        }
        public static void DisplayMovies(Movie[] movies)
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
