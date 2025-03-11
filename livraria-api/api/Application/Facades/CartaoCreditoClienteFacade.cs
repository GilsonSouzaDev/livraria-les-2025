using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Models;
using System.Linq.Expressions;

namespace livraria_api.api.Application.Facades;

public class CartaoCreditoClienteFacade : IFacadeBase<CartaoCreditoCliente>, ICartaoCreditoClienteFacade
{
    public Task<CartaoCreditoCliente> AddAsync(CartaoCreditoCliente entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(CartaoCreditoCliente entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CartaoCreditoCliente>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CartaoCreditoCliente>> GetAllAsync(Expression<Func<CartaoCreditoCliente, bool>> filter = null, Func<IQueryable<CartaoCreditoCliente>, IOrderedQueryable<CartaoCreditoCliente>> orderBy = null, string includeProperties = "")
    {
        throw new NotImplementedException();
    }

    public Task<CartaoCreditoCliente> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(CartaoCreditoCliente entity)
    {
        throw new NotImplementedException();
    }
}
