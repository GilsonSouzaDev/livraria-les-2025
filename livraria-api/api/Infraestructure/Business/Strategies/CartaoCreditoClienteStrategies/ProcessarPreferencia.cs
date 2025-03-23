using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;

namespace livraria.api.Infraestructure.Business.Strategies.CartaoCreditoClienteStrategies;
    

public class ProcessarPreferencia : IStrategieBase<CartaoCreditoCliente>
{
    private readonly ICartaoCreditoClienteRepository _cartaoCreditoClienteRepository;


    public ProcessarPreferencia(ICartaoCreditoClienteRepository cartaoCreditoClienteRepository)
    {
        _cartaoCreditoClienteRepository = cartaoCreditoClienteRepository ?? throw new ArgumentNullException(nameof(cartaoCreditoClienteRepository));
    }


    public async Task<string> Processar(CartaoCreditoCliente entidade)
    {
        if (entidade == null)
            throw new ArgumentNullException(nameof(entidade));

        //var cartoes = await _cartaoCreditoClienteRepository.GetAllAsync();

        var cartoes = await _cartaoCreditoClienteRepository.GetAllAsync(c => c.ClienteID == entidade.ClienteID);

        foreach (var cartao in cartoes)
        {
            if (cartao.ClienteID == entidade.ClienteID)
            {
                if (entidade.Preferencial)
                {
                    cartao.Preferencial = false;
                    await _cartaoCreditoClienteRepository.AtualizarPreferenciaCartao(cartao);
                }
            }
        }

        return null;
    }

}
