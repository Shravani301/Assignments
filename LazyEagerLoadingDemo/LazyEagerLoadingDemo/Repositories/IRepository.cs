using LazyEagerLoadingDemo.Models;

namespace LazyEagerLoadingDemo.Repositories
{
    public interface IRepository
    {
        public List<Student> GetStudentsLazy();
        public List<Student> GetStudentsEager();
    }
}
