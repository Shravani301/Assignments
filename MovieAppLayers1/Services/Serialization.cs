using MovieAppLayers.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieAppLayers.Services
{
    internal class Serialization
    {
        static string FilePath = ConfigurationManager.AppSettings["myFile"];
        public static List<Movie> Deserialization(List<Movie> movies)
        {
            if (!File.Exists(FilePath))
            {
                return new List<Movie>();
            }
            var jsonData = File.ReadAllText(FilePath);
            movies = JsonSerializer.Deserialize<List<Movie>>(jsonData);
            return movies;
        }
        public static string SerializationMoviesList(List<Movie> movies)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(JsonSerializer.Serialize(movies));
                return "Movies saved Successfully!";
            }
        }
    }
}
