using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace livraria_api.api.Infraestructure.Data.Repositorys;

public class EnderecoClienteRepository : RepositoryBase<EnderecoCliente>, IEnderecoClienteRepository
{
    public EnderecoClienteRepository(DbLivrariaContext context) : base(context) { }

    public async Task<bool> ExistsAsync(int id)
    {
<<<<<<< HEAD
        return await _context.EnderecosClientes.AnyAsync(e => e.EnderecoId == id); // Específico para CartaoCreditoCliente
=======
        return await _context.EnderecosClientes.AnyAsync(e => e.EnderecoId == id); // Específico para EnderecoCliente
>>>>>>> a8da6b2678709aa9e12392f9997af486f5ca127e
    }
}

