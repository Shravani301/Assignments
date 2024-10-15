using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBooksLibrary.Models
{
    public class Author
    {
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Email { get; set; } 
        public int AuthorAge { get; set; }

        public List<Book>books = new List<Book>();

        public override string ToString()
        {
            return $"Author ID:{AuthorId}\n" +
                $"Author Name:{AuthorName}\n" +
                $"Author Age:{Email}\n" +
                $"Author Email:{Email}\n";
        }

    }
}
