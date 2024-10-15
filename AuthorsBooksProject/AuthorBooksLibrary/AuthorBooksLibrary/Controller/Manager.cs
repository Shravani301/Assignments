using AuthorBooksLibrary.Exceptions;
using AuthorBooksLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthorBooksLibrary.Controller
{
    public class Manager
    {
        public static List<Author> authors = new List<Author>();
        public static List<Book> books = new List<Book>();

        // Author Management Section

        public static string CreateAuthor(string authorId, string authorName, string authorEmail, int authorAge)
        {
            Author author = new Author
            {
                AuthorId = authorId,
                AuthorName = authorName,
                Email = authorEmail,
                AuthorAge = authorAge
            };

            authors.Add(author);
            return $"Author {authorName} added successfully.";
        }

        public static string EditAuthor(string authorId, string authorName, string authorEmail, int authorAge)
        {
            var author = GetAuthor(authorId);
            if (author == null)
            {
                throw new AuthorNotFoundException("Author not found.");
            }

            author.AuthorName = authorName;
            author.Email = authorEmail;
            author.AuthorAge = authorAge;

            return $"Author {authorId} updated successfully.";
        }

        public static string DeleteAuthor(string authorId)
        {
            var author = GetAuthor(authorId);
            if (author == null)
            {
                throw new AuthorNotFoundException("Author not found.");
            }

            authors.Remove(author);
            return $"Author {authorId} deleted successfully, but books will remain.";
        }

       public static Author GetAuthor(string authorId)
        {
            var author= authors.Where(a => a.AuthorId == authorId).FirstOrDefault();
            if (author == null)
                throw new AuthorNotFoundException("No such author exist");
            return author;
        }

       public static string DisplayAuthors()
        {
            if (!authors.Any())
            {
                return "No authors found.";
            }

            string result = "List of Authors:\n";
            foreach (var author in authors)
            {
                result += $"{author}\n";
            }

            return result;
        }

        // Book Management Section

        public static string CreateBook(string bookId, string bookTitle, int pageCount, int year, string authorId)
        {
            var author = GetAuthor(authorId);
            if (author == null)
            {
                throw new AuthorNotFoundException("Author not found.");
            }
            Book book = new Book
            {
                BookId = bookId,
                BookTitle = bookTitle,
                PageCount = pageCount,
                PublishingDate = new DateOnly(year, 1, 1),
                AuthorId = authorId 
            };

            author.books.Add(book);

            books.Add(book);

            return $"Book '{bookTitle}' added to author {author.AuthorName}.";
        }

        public static string EditBook(string bookId, string bookTitle, int pageCount, int year,string authorId)
        {
            var book = GetBook(bookId);
            if (book == null)
            {
                throw new BookNotFoundException("Book not found.");
            }

            book.BookTitle = bookTitle;
            book.PageCount = pageCount;
            book.PublishingDate = new DateOnly(year, 1, 1);
            book.AuthorId = authorId;

            return $"Book {bookId} updated successfully.";
        }

        public static string DeleteBook(string bookId)
        {
            var book = GetBook(bookId);
            if (book == null)
            {
                throw new BookNotFoundException("Book not found.");
            }

            books.Remove(book);

            var author = GetAuthor(book.AuthorId);
            if (author != null)
            {
                author.books.Remove(book);
            }

            return $"Book {bookId} removed successfully.";
        }

        public static string DisplayBooks()
        {
            if (!books.Any())
            {
                return "No books found.";
            }

            string result = "List of Books:\n";
            foreach (var book in books)
            {
                result += $"{book}\n";
            }

            return result;
        }

        public static Book GetBook(string bookId)
        {
            var book = books.Where(b => b.BookId == bookId).FirstOrDefault();
            if (book == null)
            {
                throw new BookNotFoundException("Book not found.");
            }

            return book;
        }
    }
}
