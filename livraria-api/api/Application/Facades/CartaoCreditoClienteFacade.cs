using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public class CartaoCreditoClienteFacade : ICartaoCreditoClienteFacade
{
    private readonly ICartaoCreditoClienteRepository _cartaoCreditoClienteRepository;
    private readonly List<IStrategieBase<CartaoCreditoCliente>> _strategieBase;

    public CartaoCreditoClienteFacade(ICartaoCreditoClienteRepository cartaoCreditoClienteRepository, IEnumerable<IStrategieBase<CartaoCreditoCliente>> strategieBase)
    {
        _cartaoCreditoClienteRepository = cartaoCreditoClienteRepository;
        _strategieBase = strategieBase.ToList();
    }

    public async Task<CartaoCreditoCliente> AddAsync(CartaoCreditoCliente entity)
    {
        StringBuilder errors = new StringBuilder();

        foreach (var strategy in _strategieBase)
        {
            string error = await strategy.Processar(entity);
            if (!string.IsNullOrEmpty(error))
            {
                errors.AppendLine(error);
            }
        }

        if (errors.Length > 0)
        {
            throw new Exception(errors.ToString());
        }

        return await _cartaoCreditoClienteRepository.AddAsync(entity);
    }

    public async Task DeleteAsync(CartaoCreditoCliente entity)
    {
        await _cartaoCreditoClienteRepository.DeleteAsync(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _cartaoCreditoClienteRepository.ExistsAsync(id);
    }

    public async Task<IEnumerable<CartaoCreditoCliente>> GetAllAsync()
    {
        return await _cartaoCreditoClienteRepository.GetAllAsync();
    }

    public async Task<IEnumerable<CartaoCreditoCliente>> GetAllAsync(Expression<Func<CartaoCreditoCliente, bool>> filter = null, Func<IQueryable<CartaoCreditoCliente>, IOrderedQueryable<CartaoCreditoCliente>> orderBy = null, string includeProperties = "")
    {
        return await _cartaoCreditoClienteRepository.GetAllAsync(filter, orderBy, includeProperties);
    }

    public async Task<CartaoCreditoCliente> GetByIdAsync(int id)
    {
        return await _cartaoCreditoClienteRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(CartaoCreditoCliente entity)
    {
        
        StringBuilder errors = new StringBuilder();

        foreach (var strategy in _strategieBase)
        {
            string error = await strategy.Processar(entity);
            if (!string.IsNullOrEmpty(error))
            {
                errors.AppendLine(error);
            }
        }

        if (errors.Length > 0)
        {
            throw new Exception(errors.ToString());
        }
        
        await _cartaoCreditoClienteRepository.UpdateAsync(entity);
    }
}
