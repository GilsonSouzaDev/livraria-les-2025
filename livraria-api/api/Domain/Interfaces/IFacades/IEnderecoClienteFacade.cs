using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IFacades
{
    public interface IEnderecoClienteFacade : IFacadeBase<EnderecoCliente>
    {
        Task<bool> ExistsAsync(int id);
    }
}
