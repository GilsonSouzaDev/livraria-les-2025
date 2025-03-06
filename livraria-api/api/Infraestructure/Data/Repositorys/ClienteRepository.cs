using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace livraria_api.api.Infraestructure.Data.Repositorys;

public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
{
    public ClienteRepository(DbLivrariaContext context) : base(context) { }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.Clientes.AnyAsync(e => e.ClienteId == id);
    }

    public async Task<Cliente> GetClienteCompletoByIdAsync(int id)
    {
        return await _context.Clientes
            .Include(c => c.EnderecosClientes)
            .Include(c => c.TelefonesClientes)
            .Include(c => c.CartoesCreditoClientes)
                .ThenInclude(cartao => cartao.Bandeira)
            .FirstOrDefaultAsync(c => c.ClienteId == id);
    }

}

