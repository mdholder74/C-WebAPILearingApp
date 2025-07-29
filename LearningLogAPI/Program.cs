
using AutoMapper;
using LearningLogAPI.DbContexts;
using LearningLogAPI.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using LearningLog.API.Services;


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

            //This tells AutoMapper to find all profiles (like CourseProfile) in the current project and register them.
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Register your CourseService for DI
            builder.Services.AddScoped<ICourseService, CourseService>();

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
