using MovieAppLayers.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieAppLayers.Controller
{
    internal class MovieManager
    {
        static List<Movie> movies = new List<Movie>();
        static string FilePath = ConfigurationManager.AppSettings["myFile"];

        public MovieManager() 
        {
            if (File.Exists(FilePath))
            {
                var jsonData = File.ReadAllText(FilePath);
                movies = JsonSerializer.Deserialize<List<Movie>>(jsonData);
            }
        }
        public static Movie GetMovie(int id)
        { 
            return movies.Where(movies=>movies.MovieId==id).FirstOrDefault();
        }

        public void CreateMovie(int id, string name, string genre, int year)
        {
            movies.Add(new Movie(id, name, genre, year));
        }

        public void Print(int id)
        { 
            Movie movie=GetMovie(id);
            if(movie != null) 
                Console.WriteLine(movie);
            else
                Console.WriteLine("No Such Movie Exist");
        }
        public void PrintAllMovies()
        {
            Console.WriteLine("Available Movies are");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
                Console.WriteLine();
            }
            
        }
        public void ClearAllMovies()
        { 
            movies.Clear();
        }
        public void DeleteMovie(int id)
        {
            Movie movie = GetMovie(id);
            if (movie != null)
                movies.Remove(movie);
        }
        public string SerializationMovies()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(JsonSerializer.Serialize(movies));
                return "Movies saved Successfully!";
            }
        }

    }

}
