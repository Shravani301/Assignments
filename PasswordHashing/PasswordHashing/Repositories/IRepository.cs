using PasswordHashing.DTOs;

namespace PasswordHashing.Repositories
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public IQueryable<T> GetAll();
    }
}
