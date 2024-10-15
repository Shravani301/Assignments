using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorBooksLibrary.Exceptions
{
    public class AuthorNotFoundException:Exception
    {
        public AuthorNotFoundException(string message):base(message) { }
    }
}
