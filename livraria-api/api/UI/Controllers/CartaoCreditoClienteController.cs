using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace livraria_api.api.UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CartaoCreditoClienteController : Controller
{
    private readonly ICartaoCreditoClienteFacade   _cartaoCreditoClienteFacade;

    public CartaoCreditoClienteController(ICartaoCreditoClienteFacade cartaoCreditoClienteFacade)
    {
        _cartaoCreditoClienteFacade = cartaoCreditoClienteFacade;
    }

    [HttpGet]
    [Route("listar-cartoes")]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var result = await _cartaoCreditoClienteFacade.GetAllAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        try
        {
            var cartao = await _cartaoCreditoClienteFacade.GetByIdAsync(id);
            if (cartao == null)
            {
                return NotFound();
            }
            return Ok(cartao);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Erro interno do servidor.");
        }
    }


    [HttpPost]
    [Route("inserir-cartoes")]
    public async Task<IActionResult> InsertAsync([FromBody] CartaoCreditoCliente cartaoCreditoCliente)
    {
        try
        {
            await _cartaoCreditoClienteFacade.AddAsync(cartaoCreditoCliente);
            return Ok(cartaoCreditoCliente);
        }
        catch (DbUpdateException ex)
        {
            Console.WriteLine($"Erro ao salvar mudanças: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Detalhes do erro: {ex.InnerException.Message}");
            }
            throw;
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        try
        {
            var cartao = await _cartaoCreditoClienteFacade.GetByIdAsync(id);
            if (cartao is null) return NotFound();
            await _cartaoCreditoClienteFacade.DeleteAsync(cartao);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Erro interno do servidor");
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] CartaoCreditoCliente cartaoCreditoCliente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (cartaoCreditoCliente.CartaoCreditoClienteId != id)
        {
            return BadRequest("Id indicado não corresponde à um indentificador válido.");
        }

        try
        {
            // Buscando a entidade para garantir que exista
            var existingCartao = await _cartaoCreditoClienteFacade.GetByIdAsync(id);
            if (existingCartao is null) return NotFound();
            
            existingCartao.BandeiraID = cartaoCreditoCliente.BandeiraID;
            existingCartao.NumeroCartao = cartaoCreditoCliente.NumeroCartao;
            existingCartao.NomeNoCartao = cartaoCreditoCliente.NomeNoCartao;
            existingCartao.CodigoSeguranca = cartaoCreditoCliente.CodigoSeguranca;
            existingCartao.Preferencial = cartaoCreditoCliente.Preferencial;
            
            await _cartaoCreditoClienteFacade.UpdateAsync(existingCartao); // Passa *existingCartao*.
            return NoContent();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _cartaoCreditoClienteFacade.ExistsAsync(id))
            {
                return NotFound();
            }
            else
            {
                return Conflict("O cartão foi modificado por outro usuário.");
            }
        }
        catch (DbUpdateException ex)
        {
            if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY constraint failed"))
            {
                return BadRequest("Erro de chave estrangeira.");
            }
            return StatusCode(500, "Erro interno do servidor.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Erro interno do servidor.");
        }
    }


}
