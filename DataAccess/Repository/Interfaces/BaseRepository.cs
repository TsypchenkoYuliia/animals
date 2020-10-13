using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected AnimalContext _context;

        private DbSet<T> _entities;
        protected DbSet<T> Entities => this._entities ??= _context.Set<T>();

        protected BaseRepository(AnimalContext context)
        {
            _context = context;
        }

        public async Task Add(T obj)
        {
            await Entities.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<T>> Get()
        {
            return await Entities.ToListAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await Entities.FindAsync(predicate);
        }
    }
}
