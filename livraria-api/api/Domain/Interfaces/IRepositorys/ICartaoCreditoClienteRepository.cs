using livraria_api.api.Domain.Models;

namespace livraria_api.api.Domain.Interfaces.IRepositorys;

public interface ICartaoCreditoClienteRepository : IRepositoryBase<CartaoCreditoCliente>
{
    Task<bool> ExistsAsync(int id);

    Task AtualizarPreferenciaCartao(CartaoCreditoCliente cartao);

}
