
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace livraria_api.api.Infraestructure.Data.Repositorys;

public class CartaoCreditoClienteRepository : RepositoryBase<CartaoCreditoCliente>, ICartaoCreditoClienteRepository
{
    public CartaoCreditoClienteRepository(DbLivrariaContext context) : base(context){ }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.CartoesCreditoClientes.AnyAsync(e => e.CartaoCreditoClienteId == id); // Específico para CartaoCreditoCliente
    }
}

