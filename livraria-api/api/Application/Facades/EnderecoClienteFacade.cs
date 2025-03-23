using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using System.Linq.Expressions;

namespace livraria_api.api.Application.Facades;

public class EnderecoClienteFacade : IEnderecoClienteFacade
{
    private readonly IEnderecoClienteRepository _enderecoClienteRepository;

    public EnderecoClienteFacade(IEnderecoClienteRepository enderecoClienteRepository)
    {
        _enderecoClienteRepository = enderecoClienteRepository;
    }

    public async Task<EnderecoCliente> AddAsync(EnderecoCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        return await _enderecoClienteRepository.AddAsync(entity);
    }

    public async Task DeleteAsync(EnderecoCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        await _enderecoClienteRepository.DeleteAsync(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _enderecoClienteRepository.ExistsAsync(id);
    }

    public async Task<IEnumerable<EnderecoCliente>> GetAllAsync()
    {
        return await _enderecoClienteRepository.GetAllAsync();
    }

    public async Task<IEnumerable<EnderecoCliente>> GetAllAsync(Expression<Func<EnderecoCliente, bool>> filter = null, Func<IQueryable<EnderecoCliente>, IOrderedQueryable<EnderecoCliente>> orderBy = null, string includeProperties = "")
    {
        return await _enderecoClienteRepository.GetAllAsync(filter, orderBy, includeProperties);
    }

    public async Task<EnderecoCliente> GetByIdAsync(int id)
    {
        var endereco = await _enderecoClienteRepository.GetByIdAsync(id);
        if (endereco == null)
            throw new KeyNotFoundException($"EndereçoCliente com ID {id} não encontrado.");

        return endereco;
    }

    public async Task UpdateAsync(EnderecoCliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var enderecoExiste = await _enderecoClienteRepository.ExistsAsync(entity.EnderecoId);
        if (!enderecoExiste)
            throw new KeyNotFoundException($"EndereçoCliente com ID {entity.EnderecoId} não encontrado.");

        await _enderecoClienteRepository.UpdateAsync(entity);
    }
}
