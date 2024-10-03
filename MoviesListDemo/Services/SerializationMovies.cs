using MoviesListDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MoviesListDemo.Services
{
    internal class SerializationMovies
    {
        public static string FilePath = ConfigurationManager.AppSettings["myFile"];
        public static List<Movie> MoviesDeserialize()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Movie>();
            }
            using (StreamReader sr = new StreamReader(FilePath))
            {
                var jsonData = sr.ReadToEnd();
                return JsonSerializer.Deserialize<List<Movie>>(jsonData);
            }
        }
        public static string MoviesSerialization(List<Movie> movies)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(JsonSerializer.Serialize(movies));
                return "Movies saved Successfully!";
            }

        }
    }
}
