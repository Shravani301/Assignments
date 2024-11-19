using LazyEagerLoadingDemo.Data;
using LazyEagerLoadingDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace LazyEagerLoadingDemo.Repositories
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;            
        }
        // Eager Loading: Load Students and their Courses together.
        public List<Student> GetStudentsEager()
        {
            return _context.Students.Include(s => s.Courses).ToList();
        }

        // Lazy Loading: Students and Courses will be loaded only when accessed.
        public List<Student> GetStudentsLazy()
        {
            return _context.Students.ToList();
        }
    }
}
