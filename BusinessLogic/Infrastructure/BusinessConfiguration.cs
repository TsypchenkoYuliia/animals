using BusinessLogic.Services;
using DataAccess.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Infrastructure
{
    public static class BusinessConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(MapperConfig));
            services.AddTransient(typeof(CatService));
            services.AddTransient(typeof(DogService));

            DataAccessConfiguration.ConfigureServices(services, configuration);
        }
    }
}
