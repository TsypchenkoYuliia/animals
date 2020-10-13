using DataAccess.Context;
using DataAccess.Models;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository
{
    public class CatRepository : BaseRepository<Cat>
    {
        public CatRepository(AnimalContext context):base(context) {}
    }
}
