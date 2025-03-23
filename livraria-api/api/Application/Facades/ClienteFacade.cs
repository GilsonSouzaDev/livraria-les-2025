using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Repositorys;
using System.Linq.Expressions;
using System.Text;

namespace livraria_api.api.Application.Facades;

public class ClienteFacade : IClienteFacade
{
    private readonly IClienteRepository _clienteRepository;
    private readonly List<IStrategieBase<Cliente>> _strategieBase;

    public ClienteFacade(IClienteRepository clienteRepository, IEnumerable<IStrategieBase<Cliente>> strategieBase)
    {
        _clienteRepository = clienteRepository;
        _strategieBase = strategieBase.ToList();
    }

    public async Task<Cliente> AddAsync(Cliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        StringBuilder errors = new StringBuilder();

        foreach (var strategy in _strategieBase)
        {
            string? error = await strategy.Processar(entity);
            if (!string.IsNullOrEmpty(error))
            {
                errors.AppendLine(error);
            }
        }

        if (errors.Length > 0)
        {
            throw new Exception(errors.ToString());
        }

        return await _clienteRepository.AddAsync(entity);

       
    }

    public async Task DeleteAsync(Cliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        await _clienteRepository.DeleteAsync(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _clienteRepository.ExistsAsync(id);
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        return await _clienteRepository.GetAllAsync();
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync(Expression<Func<Cliente, bool>> filter = null, Func<IQueryable<Cliente>, IOrderedQueryable<Cliente>> orderBy = null, string includeProperties = "")
    {
        return await _clienteRepository.GetAllAsync(filter, orderBy, includeProperties);
    }

    public async Task<Cliente> GetByIdAsync(int id)
    {
        return await _clienteRepository.GetByIdAsync(id);
    }

    public async Task<Cliente> GetClienteCompletoByIdAsync(int id)
    {
        var cliente = await _clienteRepository.GetClienteCompletoByIdAsync(id);
        if (cliente == null)
            throw new KeyNotFoundException($"Cliente com ID {id} não encontrado.");

        return cliente;
    }

    public async Task UpdateAsync(Cliente entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var clienteExiste = await _clienteRepository.ExistsAsync(entity.ClienteId);
        if (!clienteExiste)
            throw new KeyNotFoundException($"Cliente com ID {entity.ClienteId} não encontrado.");
     
        await _clienteRepository.UpdateAsync(entity);
    }
}
