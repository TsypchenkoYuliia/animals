using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<IReadOnlyCollection<T>> Get();
        Task Add(T obj);
        Task<T> Get(Expression<Func<T, bool>> predicate);
    }
}
