
using LazyEagerLoadingDemo.Data;
using LazyEagerLoadingDemo.Mappers;
using LazyEagerLoadingDemo.Repositories;
using LazyEagerLoadingDemo.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace LazyEagerLoadingDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddTransient<IRepository, Repository>();
            builder.Services.AddTransient<IService, StudentService>();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies().
                UseSqlServer(builder.Configuration.GetConnectionString("connString"))
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            });
            builder.Services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAutoMapper(typeof(MappingProfile));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
