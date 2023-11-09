using CommandsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using Npgsql;
using System;
using System.Reflection;

namespace CommandsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new web application builder.
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Version = "v1",
                        Title = "Commands API",
                        Description = "An ASP.NET Core Web API for managing Commands",
                        TermsOfService = new Uri("https://example.com/terms"),
                        Contact = new OpenApiContact
                        {
                            Name = "Contact via Linkedin",
                            Url = new Uri("https://www.linkedin.com/in/sit-bulu/")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "Example License",
                            Url = new Uri("https://example.com/license")
                        }
                    });
                }
                
                );

            // Register a repository implementation with dependency injection.
            // Replace this with your actual repository implementation.
            // builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();
            builder.Services.AddScoped<ICommandAPIRepo, SqlCommandAPIRepo>();

            // Configure Entity Framework Core to use PostgreSQL database.
            builder.Services.AddDbContext<CommandContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));

            // Configure AutoMapper and scan for mapping profiles in the current assembly.
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            // Alternatively, you can specify a specific assembly:
            // builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Configure JSON serialization settings to use camelCase property names.
            builder.Services.AddControllers().AddNewtonsoftJson(settings =>
            {
                settings.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
            

           


            // Build the application.
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            if (!app.Environment.IsDevelopment())
            {
                // Handle exceptions and configure HSTS (HTTP Strict Transport Security) in production.
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });

            // Redirect HTTP to HTTPS and serve static files.
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            // Configure routing for controllers.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Start the application.
            app.Run();
        }
    }
}
