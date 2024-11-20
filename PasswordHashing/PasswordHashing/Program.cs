
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PasswordHashing.Data;
using PasswordHashing.Exceptions;
using PasswordHashing.Mappers;
using PasswordHashing.Repositories;
using PasswordHashing.Services;
using System.Text.Json.Serialization;

namespace PasswordHashing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options=>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("connString"));
            });
            builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddTransient<IService, EmployeeService>();

            builder.Services.AddControllers();

            builder.Services.AddControllers().AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddAutoMapper(typeof(MappingProfile));


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            builder.Services.AddExceptionHandler<AppExceptionHandler>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseExceptionHandler(_ => { });

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
