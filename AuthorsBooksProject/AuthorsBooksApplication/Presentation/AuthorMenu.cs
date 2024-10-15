using AuthorBooksLibrary.Controller;
using AuthorBooksLibrary.Exceptions;
using AuthorBooksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsBooksApplication.Presentation
{
    public class AuthorMenu
    {
        public static void DisplayAuthorMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Welcome to Author Management\n" +
                    "Select what do you wish to do?\n" +
                    "1. Add Author\n" +
                    "2. Edit Author Details\n" +
                    "3. Display all Authors\n" +
                    "4. Delete Author\n" +
                    "5. Display Author\n" +
                    "6. Exit to Main Menu\n" +
                    "Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            }
        }
        public static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddAuthor();
                    break;
                case 2:
                    EditAuthor1();
                    break;
                case 3:
                    DisplayAllAuthors();
                    break;
                    case 4:
                    DeleteAuthor();
                    break;
                    case 5:
                    DisplayAuthor();
                    break;
                    case 6:
                    Menu.MainMenu();
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
        public static void AddAuthor()
        {
            Console.WriteLine("Enter authorId:");
            string authorId= Console.ReadLine();
            Console.WriteLine("Enter author name:");
            string authorName= Console.ReadLine();
            Console.WriteLine("Enter author Email:");
            string authorEmail= Console.ReadLine();
            Console.WriteLine("Enter author age:");
            int authorAge= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Manager.CreateAuthor(authorId,
                authorName,authorEmail,authorAge));
        }
        public static void EditAuthor1()
        {
            Console.WriteLine("Enter authorId");
            string authorId = Console.ReadLine();
            try
            {
                Author author = Manager.GetAuthor(authorId);
                if (author != null)
                {
                    Console.WriteLine("Enter author name:");
                    string authorName = Console.ReadLine();
                    Console.WriteLine("Enter author Email:");
                    string authorEmail = Console.ReadLine();
                    Console.WriteLine("Enter author age:");
                    int authorAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Manager.EditAuthor(authorId,
                authorName, authorEmail, authorAge));
                }
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteAuthor()
        {
            Console.WriteLine("Enter authorId");
            string authorId = Console.ReadLine();
            try
            {
                Author author = Manager.GetAuthor(authorId);
                if (author != null)
                    Console.WriteLine(Manager.DeleteAuthor(authorId));
            }
            catch(AuthorNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayAuthor()
        {
            Console.WriteLine("Enter authorId");
            string authorId = Console.ReadLine();
            try
            {
                Author author = Manager.GetAuthor(authorId);
                if (author != null)
                    Console.WriteLine(author);
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void DisplayAllAuthors()
        {
           Console.WriteLine(Manager.DisplayAuthors());
        }
    }
}
