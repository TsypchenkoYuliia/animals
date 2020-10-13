using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Context.Initializer
{
    public static class DbInitializer
    {
        public static void Initialize(AnimalContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cats.Any())
            {
                return;
            }

            context.Cats.AddRange(new Cat[] {
                new Cat() { Name = "Murzik", Age = 5 },
            });

            context.Dogs.AddRange(new Dog[] {
                new Dog() { Name = "Rem", Age = 2 },
            });

            context.SaveChanges();
        }
    }
}
