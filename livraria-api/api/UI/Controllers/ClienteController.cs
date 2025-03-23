using AutoMapper;
using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys; // Certifique-se de ter este using
using livraria_api.api.Domain.Models;
using livraria_api.api.UI.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace livraria_api.api.UI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteFacade _clienteFacade; // Injeta diretamente o repositório
    private IMapper _mapper;

    public ClienteController(IClienteFacade clienteFacade, IMapper mapper)
    {
        _clienteFacade = clienteFacade;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetClienteCompleto(int id)
    {
        try
        {
            var cliente = await _clienteFacade.GetClienteCompletoByIdAsync(id); // Usa o método do repositório
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Erro interno do servidor.");
        }
    }
    [HttpGet]
    [Route("listar")]
    public async Task<IActionResult> GetAllAsync()
    {
        try
        {
            var result = await _clienteFacade.GetAllAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost]
    [Route("inserir")]
    public async Task<IActionResult> CreateAsync([FromBody] ClienteCreateDto clienteDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
           
            var novoCliente = _mapper.Map<Cliente>(clienteDto);
            await _clienteFacade.AddAsync(novoCliente);
            return Ok();
        }
        catch (Exception ex)
        {
            //Breakpoint aqui!
            return StatusCode(500, $"Erro interno: {ex.Message}. Detalhes: {ex.InnerException?.Message ?? "N/A"}");
        }

    }


    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(int id, [FromBody] Cliente cliente)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        if (cliente.ClienteId != id)
        {
            return BadRequest("Id inválido");
        }

        try
        {
            // Buscando a entidade para garantir que exista
            var existingCliente = await _clienteFacade.GetByIdAsync(id);
            if (existingCliente is null) return NotFound();

            existingCliente.Nome = cliente.Nome;
            existingCliente.Email = cliente.Email;
            existingCliente.Cpf = cliente.Cpf;
            existingCliente.Genero = cliente.Genero;
            existingCliente.Ranking = cliente.Ranking;
            existingCliente.DataNascimento = cliente.DataNascimento;
            existingCliente.CodigoCliente = cliente.CodigoCliente;
            existingCliente.Ativo = cliente.Ativo;

            //Removendo a Atualização dos relacionamentos, vamos criar controllers separados para isso.


            await _clienteFacade.UpdateAsync(existingCliente);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        try
        {
            var cliente = await _clienteFacade.GetByIdAsync(id);
            if (cliente is null)
            {
                throw new Exception("Cliente não encontrado");
            }
            await _clienteFacade.DeleteAsync(cliente);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}