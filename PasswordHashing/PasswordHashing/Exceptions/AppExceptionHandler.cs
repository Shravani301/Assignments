using Microsoft.AspNetCore.Diagnostics;
using PasswordHashing.Models;
using System.ComponentModel.DataAnnotations;

namespace PasswordHashing.Exceptions
{
    public class AppExceptionHandler:IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
        Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse();
            if (exception is ValidationException validationException)
            {
                response.StatusCode = StatusCodes.Status400BadRequest;
                response.ExceptionMessage = validationException.Message;
                response.Title = "Validation Error";
            }
            else if (exception is InvalidPasswordException)
            {
                response.StatusCode = StatusCodes.Status401Unauthorized;
                response.ExceptionMessage = exception.Message;
                response.Title = "Invalid Credentials";
            }
            else if (exception is UserNotFoundException)
            {
                response.StatusCode = StatusCodes.Status404NotFound;
                response.ExceptionMessage = exception.Message;
                response.Title = "User Not found";
            }
            else
            {
                response.StatusCode = StatusCodes.Status500InternalServerError;
                response.ExceptionMessage = exception.Message ?? "An unexpected error occurred.";
                response.Title = "Server Error";
            }
            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            return true;

        }
    }
}
