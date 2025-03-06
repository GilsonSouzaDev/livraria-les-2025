using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface IClienteRepository : IRepositoryBase<Cliente>
{
    Task<Cliente> GetClienteCompletoByIdAsync(int id);
    Task<bool> ExistsAsync(int id); // Adicione aqui

}