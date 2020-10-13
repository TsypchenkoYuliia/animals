using DataAccess.Context;
using DataAccess.Models;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class DogRepository : BaseRepository<Dog>
    {
        public DogRepository(AnimalContext context) : base(context) { }
    }
}
