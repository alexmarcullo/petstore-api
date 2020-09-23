using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Petstore.Domain.Shared.Entities;

namespace Petstore.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<ICollection<T>> GetAsync(Expression<Func<bool, T>> expression);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}