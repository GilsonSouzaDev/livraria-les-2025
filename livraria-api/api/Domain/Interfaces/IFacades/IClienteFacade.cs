using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IFacades
{
    public interface IClienteFacade : IFacadeBase<Cliente>
    {
        Task<Cliente> GetClienteCompletoByIdAsync(int id);
        Task<bool> ExistsAsync(int id);

    }
}
