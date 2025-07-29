
using LearningLogAPI.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace LearningLogAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<CourseInfoContext>(dbContextOptions =>
            dbContextOptions.UseSqlite(
                builder.Configuration["ConnectionStrings:CourseInfoDBConnectionString"]));

            // Add services to the container for Build Setup.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline for Middleware.
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
