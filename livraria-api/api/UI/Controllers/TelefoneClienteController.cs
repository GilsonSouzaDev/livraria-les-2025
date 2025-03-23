using AutoMapper;
using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Repositorys;
using livraria_api.api.UI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefoneClienteCreateDto = livraria_api.api.UI.DTOs.TelefoneClienteCreateDto;
using TelefoneClienteUpdateDto = livraria_api.api.UI.DTOs.TelefoneClienteUpdateDto;

namespace livraria_api.api.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoneClienteController : ControllerBase
    {
        private readonly ITelefoneClienteFacade _tefoneClienteFacade;
        private IMapper _mapper;

        public TelefoneClienteController(ITelefoneClienteFacade tefoneClienteFacade, IMapper mapper)
        {
            this._tefoneClienteFacade = tefoneClienteFacade;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("listar-telefones")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _tefoneClienteFacade.GetAllAsync();
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
                var telefone = await _tefoneClienteFacade.GetByIdAsync(id);
                if (telefone == null)
                {
                    return NotFound();
                }
                return Ok(telefone);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor.");
            }
        }

        [HttpPost]
        [Route("inserir-telefones")]
        public async Task<IActionResult> InsertAsync([FromBody] TelefoneClienteCreateDto telefoneClienteDto)
        {
            try
            {
                var telefoneCliente = _mapper.Map<TelefoneCliente>(telefoneClienteDto);
                await _tefoneClienteFacade.AddAsync(telefoneCliente);
                return Ok(telefoneCliente);
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
                var telefone = await _tefoneClienteFacade.GetByIdAsync(id);
                if (telefone is null) return NotFound("Este identificador não corresponde a um telefone valido");
                await _tefoneClienteFacade.DeleteAsync(telefone);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] TelefoneClienteUpdateDto telefoneClienteUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (telefoneClienteUpdateDto.telefoneId != id)
            {
                return BadRequest("Id indicado não corresponde à um indentificador válido.");
            }

            try
            {
                // Buscando a entidade para garantir que exista
                var existingTelefone = await _tefoneClienteFacade.GetByIdAsync(id);
                if (existingTelefone is null) return NotFound();

                existingTelefone.TipoTelefone = telefoneClienteUpdateDto.TipoTelefone;
                existingTelefone.Ddd = telefoneClienteUpdateDto.Ddd;
                existingTelefone.Numero = telefoneClienteUpdateDto.Numero;
               

                await _tefoneClienteFacade.UpdateAsync(existingTelefone); // Passa *existingCartao*.
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _tefoneClienteFacade.ExistsAsync(id))
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
}
