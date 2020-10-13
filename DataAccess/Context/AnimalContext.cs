using DataAccess.Context.Initializer;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    public class AnimalContext:DbContext
    {
        IConfiguration _configuration;

        public AnimalContext(DbContextOptions<AnimalContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            DbInitializer.Initialize(this);
        }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}
