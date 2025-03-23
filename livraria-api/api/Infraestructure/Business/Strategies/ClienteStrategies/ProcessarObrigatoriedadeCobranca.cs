using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;

namespace livraria_api.api.Infraestructure.Business.Strategies.ClienteStrategies
{
    public class ProcessarObrigatoriedadeCobranca : IStrategieBase<Cliente>
    {
        public async Task<string> Processar(Cliente entidade)
        {
            // Se o cliente tiver pelo menos um endereço de cobrança, tudo certo
            var enderecosDeCobranca = entidade.EnderecosClientes.Where(e => (bool)e.UsoCobranca).ToList();

            // Se não houver nenhum endereço de cobrança marcado, retorna a mensagem
            if (enderecosDeCobranca.Count == 0)
            {
                return "O cliente deve ter pelo menos um endereço de cobrança cadastrado.";
            }

            // Se houver um ou mais endereços de cobrança, não precisa fazer nada
            return null;
        }

    }
}
