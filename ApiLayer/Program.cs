
using BusnessLayer.Abstraction;
using BusnessLayer.Concret;
using DataAccessLayer;
using DataAccessLayer.Abstriction;
using DataAccessLayer.Concret;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ApplicationContext>();
            builder.Services.AddScoped<IServiceRestorant,RestorantManager>();
            builder.Services.AddScoped<IEFRetorant,RepositoryRestornat>();


            builder.Services.AddIdentityApiEndpoints<IdentityUser>().
                AddEntityFrameworkStores<ApplicationContext>();
            builder.Services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
