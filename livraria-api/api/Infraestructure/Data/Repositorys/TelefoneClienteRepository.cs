using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace livraria_api.api.Infraestructure.Data.Repositorys;

public class TelefoneClienteRepository : RepositoryBase<TelefoneCliente>, ITelefoneClienteRepository
{
    public TelefoneClienteRepository(DbLivrariaContext context) : base(context) { }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.TelefonesClientes.AnyAsync(e => e.TelefoneId == id);
    }
}

