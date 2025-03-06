
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface IRepositoryBase<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity); 
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

}
