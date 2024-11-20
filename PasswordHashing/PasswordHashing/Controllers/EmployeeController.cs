using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordHashing.DTOs;
using PasswordHashing.Services;
using System.ComponentModel.DataAnnotations;

namespace PasswordHashing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IService _service;
        public EmployeeController(IService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Add(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = string.Join("; ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                throw new ValidationException($"{errors}");
            }
            return Ok(_service.Add(employeeDto));

        }
        [HttpPost("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var result = _service.Login(loginDto);
            return Ok(result);
        }
    }
}
