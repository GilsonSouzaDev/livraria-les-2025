using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IFacades
{
    public interface ITelefoneClienteFacade : IFacadeBase<TelefoneCliente>
    {
        Task<bool> ExistsAsync(int id);
    }
}
