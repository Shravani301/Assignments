using AuthorBooksLibrary.Controller;
using AuthorBooksLibrary.Exceptions;
using AuthorBooksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsBooksApplication.Presentation
{
    public class BookMenu
    {
        public static void DisplayBookMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Welcome to Book Management\n" +
                    "Select what do you wish to do?\n" +
                    "1. Add Book\n" +
                    "2. Edit Book Details\n" +
                    "3. Display all Books\n" +
                    "4. Delete Book\n" +
                    "5. Display Book\n" +
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
                    AddBook();
                    break;
                case 2:
                    EditBook1();
                    break;
                case 3:
                    DisplayAllBooks();
                    break;
                case 4:
                    DeleteBook();
                    break;
                case 5:
                    DisplayBook();
                    break;
                case 6:
                    Menu.MainMenu();
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
        public static void AddBook()
        {
            try
            {
                Console.WriteLine("Enter bookId:");
                string bookId = Console.ReadLine();
                Console.WriteLine("Enter Book name:");
                string bookName = Console.ReadLine();
                Console.WriteLine("Enter Number of Pages:");
                int pageCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Publishing year:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Author ID:");
                string authorId = Console.ReadLine();
                Console.WriteLine(Manager.CreateBook(bookId,
                    bookName, pageCount, year, authorId));
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public static void EditBook1()
        {
            Console.WriteLine("Enter BookId");
            string bookId = Console.ReadLine();
            try
            {
                Book book = Manager.GetBook(bookId);

                if (book != null)
                {
                    Console.WriteLine("Enter Book name:");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter Number of Pages:");
                    int pageCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Publishing year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Author ID:");
                    string authorId = Console.ReadLine();
                    Console.WriteLine(Manager.EditBook(bookId,
                        bookName, pageCount, year, authorId));
                }
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public static void DeleteBook()
        {
            Console.WriteLine("Enter BookId");
            string bookId = Console.ReadLine();
            try
            {
                Book book = Manager.GetBook(bookId);

                if (book != null)
                    Console.WriteLine(Manager.DeleteBook(bookId));
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayBook()
        {
            Console.WriteLine("Enter BookId");
            string bookId = Console.ReadLine();
            try
            {
                Book book = Manager.GetBook(bookId);
                if (book != null)
                    Console.WriteLine(book);
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void DisplayAllBooks()
        {
            Console.WriteLine(Manager.DisplayBooks());
        }

    }
}
