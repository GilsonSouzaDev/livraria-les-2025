using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface ITelefoneClienteRepository : IRepositoryBase<TelefoneCliente>
{
    Task<bool> ExistsAsync(int id); // Adicione aqui
}