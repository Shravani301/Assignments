﻿namespace PasswordHashing.Models
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string ExceptionMessage { get; set; }
        public string Title { get; set; }
    }

}
