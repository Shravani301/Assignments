using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppLayers.Exceptions
{
    internal class MovieNotFoundByNameException:Exception
    {
        public MovieNotFoundByNameException(string message)
       : base(message) { }
    }
}
