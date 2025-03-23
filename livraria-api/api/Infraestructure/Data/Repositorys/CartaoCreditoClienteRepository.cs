
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
        return await _context.CartoesCreditoClientes.AnyAsync(e => e.CartaoCreditoClienteId == id);
    }

    /*
    public async Task AtualizarPreferenciaCartao(CartaoCreditoCliente cartao)
    {
        _context.CartoesCreditoClientes.Attach(cartao);
        _context.Entry(cartao).Property(c => c.Preferencial).IsModified = true;
        await _context.SaveChangesAsync();
    }
    */

    public async Task AtualizarPreferenciaCartao(CartaoCreditoCliente cartao)
    {
        var existingCartao = await _context.CartoesCreditoClientes.FindAsync(cartao.CartaoCreditoClienteId);
        if (existingCartao != null)
        {
            existingCartao.Preferencial = cartao.Preferencial; // Atualiza a propriedade Preferencial
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Cartão não encontrado para atualização da preferência.");
        }

    }



}

