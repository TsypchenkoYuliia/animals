using DataAccess.Context;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Infrastructure
{
    public static class DataAccessConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(CatRepository));
            services.AddTransient(typeof(DogRepository));

            services.AddDbContext<AnimalContext>(option =>
                option.UseSqlServer(($"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename={Directory.GetParent(Directory.GetCurrentDirectory())}\\DataAccess\\DB\\AnimalsDb.mdf;Integrated Security=True")));
        }
    }
}
