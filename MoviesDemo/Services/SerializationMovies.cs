using MoviesDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace MoviesDemo.Services
{
    internal class SerializationMovies
    {
        public static string FilePath = ConfigurationManager.AppSettings["myFile"];
        public static Movie[] MoviesDeserialize()
        {
            if (!File.Exists(FilePath))
            {
                return new Movie[0];
            }
            using (StreamReader sr = new StreamReader(FilePath))
            {
                var jsonData = sr.ReadToEnd();
                return JsonSerializer.Deserialize<Movie[]>(jsonData);
            }
        }
        public static string MoviesSerialization(Movie[] movies)
        {
            var jsonData= JsonSerializer.Serialize(movies);

            File.WriteAllText(FilePath, jsonData);
            return "successfully saved";

        }
    }
}
