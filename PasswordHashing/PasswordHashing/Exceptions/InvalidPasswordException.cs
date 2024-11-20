using System.Globalization;

namespace PasswordHashing.Exceptions
{
    public class InvalidPasswordException:Exception
    {
        public InvalidPasswordException(String message) : base(message) { } 
    }
}
