using AutoMapper;
using Azure.Core;
using LazyEagerLoadingDemo.DTOs;
using LazyEagerLoadingDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
namespace LazyEagerLoadingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //    Use lazy loading selectively, only when appropriate.
    //    lazy loading Reduces initial query size (only fetches data you need at that moment)
    //For frequent access patterns, switch to eager loading to reduce database round-trips.
    //Use logging or profiling tools to detect and eliminate N+1 query issues during development.

    public class StudentController : ControllerBase
    {
       private readonly IService _studentService;
            private readonly IMapper _mapper;

            public StudentController(IService studentService, IMapper mapper)
            {
                _studentService = studentService;
                _mapper = mapper;
            }

            [HttpGet("lazy")]
            public IActionResult GetStudentsLazy()
            {
                var students = _studentService.GetStudentsByLazy();
                return Ok(students);
            }

            [HttpGet("eager")]
            public IActionResult GetStudentsEager()
            {
                var students = _studentService.GetStudentsByEager();
                return Ok(students);
            }
    }
}
