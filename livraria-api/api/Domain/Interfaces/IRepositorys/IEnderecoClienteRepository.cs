using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface IEnderecoClienteRepository : IRepositoryBase<EnderecoCliente>
{
<<<<<<< HEAD
    Task<bool> ExistsAsync(int id);
=======
    Task<bool> ExistsAsync(int id); // Adicione aqui
>>>>>>> a8da6b2678709aa9e12392f9997af486f5ca127e
}