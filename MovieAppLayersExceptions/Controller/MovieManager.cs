using MovieAppLayers.Exceptions;
using MovieAppLayers.Models;
using MovieAppLayers.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieAppLayers.Controller
{
    internal class MovieManager
    {
        static List<Movie> movies = new List<Movie>();

        public MovieManager()
        {
            movies = Serialization.Deserialization(movies);
        }

        public Movie GetMovieByID(int id)
        {
            if (movies.Count == 0)
            {
                throw new ZeroMoviesException("Zero Movies exist in the store.");
            }

            var movie = movies.FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                throw new MovieNotFoundByIdException($"No movie with ID {id} exists.");
            }
            return movie;
        }

        public  Movie GetMovieByName(string name)
        {
            if (movies.Count == 0)
            {
                throw new ZeroMoviesException("Zero Movies exist in the store.");
            }

            var movie = movies.FirstOrDefault(m => m.MovieName == name);
            if (movie == null)
            {
                throw new MovieNotFoundByNameException($"No movie with the name '{name}' exists.");
            }
            return movie;
        }

        public void CreateMovie(int id, string name, string genre, int year)
        {
            if (movies.Count >= 5)
            {
                throw new MovieStoreFullException("Cannot add more than 5 movies. Movie store is full.");
            }
            movies.Add(new Movie(id, name, genre, year));
        }

        public void Print(int id)
        {
            Movie movie = GetMovieByID(id);
            if (movie != null)
                Console.WriteLine(movie);
            else
                Console.WriteLine("No Such Movie Exist");
        }

        public void PrintAllMovies()
        {
            if (movies.Count == 0)
            {
                throw new ZeroMoviesException("Zero Movies exist in the store.");
            }

            Console.WriteLine("Available Movies:");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        public void ClearAllMovies()
        {
            if (movies.Count == 0)
            {
                throw new ZeroMoviesException("Zero Movies exist in the store.");
            }

            movies.Clear();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = GetMovieByID(id);
            if (movie != null)
                movies.Remove(movie);
        }

        public void EditMovie(int id, string name, string genre, int year)
        {
            Movie movie = GetMovieByID(id);
            if (movie != null)
            {
                movie.MovieName = name;
                movie.MovieGenre = genre;
                movie.MovieYear = year;
            }
        }

        public string SerializationMovies()
        {
            return Serialization.SerializationMoviesList(movies);
        }
    }
}
