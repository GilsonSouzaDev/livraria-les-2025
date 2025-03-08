using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface IEnderecoClienteRepository : IRepositoryBase<EnderecoCliente>
{
    Task<bool> ExistsAsync(int id); // Adicione aqui
}