using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBooksLibrary.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public string BookTitle { get; set; }
        public int PageCount {  get; set; }
        public DateOnly PublishingDate { get; set; }
        public string AuthorId { get; set; }

        public override string ToString()
        {
            return $"-----Book Details-----\n" +
                $"Book Id:{BookId}\n" +
                $"Book Name:{BookTitle}\n" +
                $"NumberOfPages:{PageCount}\n" +
                $"PublishingDate:{PublishingDate}\n" +
                $"Author ID:{AuthorId}\n";
        }

    }
}
