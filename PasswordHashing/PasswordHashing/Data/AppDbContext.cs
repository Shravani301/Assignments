using Microsoft.EntityFrameworkCore;
using PasswordHashing.Models;

namespace PasswordHashing.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
    }
}
