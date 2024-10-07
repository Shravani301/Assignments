using MovieAppLayers.Controller;
using MovieAppLayers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLayers.Presentation
{
    internal class MovieMenu
    {
        static MovieManager manager=new MovieManager();
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice to perform Operation");
                Console.WriteLine("1. Display Movie\n" +
                    "2. Add Movie\n" +
                    "3. Clear All Movies\n" +
                    "4. Clear Movie\n" +
                    "5. Display All movies\n" +
                    "6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            }
            
        }
        public static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    DisplayMovie();
                    break;
                case 2:
                    AddMovie();
                    break;
                case 3:
                    ClearAll();
                    break;
                case 4:
                    ClearMovie();
                    break;
                case 5:
                    DisplayAllMovies();
                    break;
                case 6:
                    manager.SerializationMovies();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ïnvalid Input please enter correct");
                    break;
            }
        }
        public static void DisplayMovie()
        {
            Console.WriteLine("Enter Movie Id");
            int Id=Convert.ToInt32(Console.ReadLine());
            manager.Print(Id);
        }
        public static void AddMovie()
        {
            Console.WriteLine("Enter Movie ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Movie Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Genre of Movie");
            string genre=Console.ReadLine();
            Console.WriteLine("Enter year of release");
            int year=Convert.ToInt32(Console.ReadLine());
            manager.CreateMovie(id, name, genre, year);
        }
        public static void ClearAll()
        {
            manager.ClearAllMovies();
        }
        public static void ClearMovie()
        {
            Console.WriteLine("Enter a movie Id:");
            int Id=Convert.ToInt32(Console.ReadLine()) ;
            manager.DeleteMovie(Id);    
        }

        public static void DisplayAllMovies()
        {
            manager.PrintAllMovies();
        }

    }
}
