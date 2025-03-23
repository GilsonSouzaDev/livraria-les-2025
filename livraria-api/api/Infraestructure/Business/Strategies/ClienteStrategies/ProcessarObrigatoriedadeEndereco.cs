using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;

namespace livraria_api.api.Infraestructure.Business.Strategies.ClienteStrategies
{
    public class ProcessarObrigatoriedadeEndereco : IStrategieBase<Cliente>
    {

        public async Task<string> Processar(Cliente entidade)
        {
          
            if (entidade.EnderecosClientes.Count < 1)
            {
                return "O cliente deve ter pelo menos um endereço cadastrado.";
            }

            return null;
        }
    }
}
