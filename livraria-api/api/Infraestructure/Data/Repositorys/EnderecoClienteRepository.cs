using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Context;

namespace livraria_api.api.Infraestructure.Data.Repositorys;

public class EnderecoClienteRepository : RepositoryBase<EnderecoCliente>, IEnderecoClienteRepository
{
    public EnderecoClienteRepository(DbLivrariaContext context) : base(context) { }
}

