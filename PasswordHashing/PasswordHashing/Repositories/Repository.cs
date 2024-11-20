using Microsoft.EntityFrameworkCore;
using PasswordHashing.Data;
using PasswordHashing.DTOs;
using PasswordHashing.Models;

namespace PasswordHashing.Repositories
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public Repository(AppDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }
        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }
        
    }
}
