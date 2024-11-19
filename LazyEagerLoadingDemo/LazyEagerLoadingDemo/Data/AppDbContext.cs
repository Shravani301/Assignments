using LazyEagerLoadingDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LazyEagerLoadingDemo.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
