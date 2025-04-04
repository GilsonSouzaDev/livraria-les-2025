﻿using AutoMapper;
using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Models;
using livraria_api.api.UI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnderecoClienteCreateDto = livraria_api.api.UI.DTOs.EnderecoClienteCreateDto;
using EnderecoClienteUpdateDto = livraria_api.api.UI.DTOs.EnderecoClienteUpdateDto;

namespace livraria_api.api.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoClienteController : ControllerBase
    {
        private readonly IEnderecoClienteFacade _enderecoClienteFacade;
        private IMapper _mapper;

        public EnderecoClienteController(IEnderecoClienteFacade enderecoClienteFacade, IMapper mapper)
        {
            this._enderecoClienteFacade = enderecoClienteFacade;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("listar-enderecos")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _enderecoClienteFacade.GetAllAsync();
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
                var telefone = await _enderecoClienteFacade.GetByIdAsync(id);
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
        [Route("inserir-enderecos")]
        public async Task<IActionResult> InsertAsync([FromBody] EnderecoClienteCreateDto enderecoClienteDto)
        {
            try
            {
                var enderecoCliente = _mapper.Map<EnderecoCliente>(enderecoClienteDto);
                await _enderecoClienteFacade.AddAsync(enderecoCliente);
                return Ok(enderecoCliente);
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
                var telefone = await _enderecoClienteFacade.GetByIdAsync(id);
                if (telefone is null) return NotFound("Este identificador não corresponde a um telefone valido");
                await _enderecoClienteFacade.DeleteAsync(telefone);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro interno do servidor");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] EnderecoClienteUpdateDto enderecoClienteUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (enderecoClienteUpdateDto.enderecoId != id)
            {
                return BadRequest("Id indicado não corresponde à um indentificador válido.");
            }

            try
            {
                // Buscando a entidade para garantir que exista
                var existingEndereco = await _enderecoClienteFacade.GetByIdAsync(id);
                if (existingEndereco is null) return NotFound();

                existingEndereco.NomeEndereco = enderecoClienteUpdateDto.NomeEndereco;
                existingEndereco.TipoResidencia = enderecoClienteUpdateDto.TipoResidencia;
                existingEndereco.TipoLogradouro = enderecoClienteUpdateDto.TipoLogradouro;
                existingEndereco.Logradouro = enderecoClienteUpdateDto.Logradouro;
                existingEndereco.Numero = enderecoClienteUpdateDto.Numero;
                existingEndereco.Bairro = enderecoClienteUpdateDto.Bairro;
                existingEndereco.Cep = enderecoClienteUpdateDto.Cep;
                existingEndereco.Cidade = enderecoClienteUpdateDto.Cidade;
                existingEndereco.Estado = enderecoClienteUpdateDto.Estado;
                existingEndereco.Pais = enderecoClienteUpdateDto.Pais;
                existingEndereco.Observacoes = enderecoClienteUpdateDto.Observacoes;
                existingEndereco.UsoCobranca = enderecoClienteUpdateDto.UsoCobranca;



                await _enderecoClienteFacade.UpdateAsync(existingEndereco); // Passa *existingCartao*.
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _enderecoClienteFacade.ExistsAsync(id))
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
