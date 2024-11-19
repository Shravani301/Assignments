using LazyEagerLoadingDemo.DTOs;
using LazyEagerLoadingDemo.Models;

namespace LazyEagerLoadingDemo.Services
{
    public interface IService
    {
        public List<StudentDto> GetStudentsByEager();
        public List<StudentDto> GetStudentsByLazy();
    }
}
