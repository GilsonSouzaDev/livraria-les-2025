using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using System.Linq.Expressions;

namespace livraria_api.api.Application.Facades;

public class TelefoneClienteFacade : ITelefoneClienteFacade
{
    private readonly ITelefoneClienteRepository _telefoneClienteRepository;

    public TelefoneClienteFacade(ITelefoneClienteRepository telefoneClienteRepository)
    {
        _telefoneClienteRepository = telefoneClienteRepository;
    }

    public async Task<TelefoneCliente> AddAsync(TelefoneCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        return await _telefoneClienteRepository.AddAsync(entity);
    }

    public async Task DeleteAsync(TelefoneCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        await _telefoneClienteRepository.DeleteAsync(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _telefoneClienteRepository.ExistsAsync(id);
    }

    public async Task<IEnumerable<TelefoneCliente>> GetAllAsync()
    {
        return await _telefoneClienteRepository.GetAllAsync();
    }

    public async Task<IEnumerable<TelefoneCliente>> GetAllAsync(Expression<Func<TelefoneCliente, bool>> filter = null, Func<IQueryable<TelefoneCliente>, IOrderedQueryable<TelefoneCliente>> orderBy = null, string includeProperties = "")
    {
        return await _telefoneClienteRepository.GetAllAsync(filter, orderBy, includeProperties);
    }

    public async Task<TelefoneCliente> GetByIdAsync(int id)
    {
        var telefone = await _telefoneClienteRepository.GetByIdAsync(id);
        if (telefone == null)
            throw new KeyNotFoundException($"TelefoneCliente com ID {id} não encontrado.");

        return telefone;
    }

    public async Task UpdateAsync(TelefoneCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var telefoneExiste = await _telefoneClienteRepository.ExistsAsync(entity.TelefoneId);
        if (!telefoneExiste)
            throw new KeyNotFoundException($"TelefoneCliente com ID {entity.TelefoneId} não encontrado.");

        await _telefoneClienteRepository.UpdateAsync(entity);
    }
}
