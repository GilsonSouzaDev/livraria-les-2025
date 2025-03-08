using AutoMapper;
using livraria_api.api.Domain.Models;
using livraria_api.api.UI.DTOs.ClienteDTO;
using livraria_api.api.UI.DTOs.EnderecoDTO;
using livraria_api.api.UI.DTOs.TelefoneDTO;

namespace livraria_api.api.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        // Mapeamento de ClienteDto para Cliente
        CreateMap<ClienteDto, Cliente>()
            .ForMember(dest => dest.ClienteId, opt => opt.MapFrom(src => src.Id)) // Consistência no nome do campo
            .ForMember(dest => dest.Cpf, opt => opt.MapFrom(src => src.CPF))
            .ForMember(dest => dest.Ranking, opt => opt.MapFrom(src => src.Ranking ?? 0)) // Definir valor padrão para Ranking se nulo
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo)); // Definir valor de Ativo se nulo

        // Mapeamento para atualização de Cliente (ClienteUpdateDto -> Cliente)
        CreateMap<ClienteUpdateDto, Cliente>()
            .ForMember(dest => dest.ClienteId, opt => opt.Ignore()) // Não queremos atualizar o ClienteId
            .ForMember(dest => dest.Cpf, opt => opt.MapFrom(src => src.CPF)) // Mapeando CPF
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
            .ForMember(dest => dest.Ranking, opt => opt.MapFrom(src => src.Ranking ?? 0)) // Definir valor padrão para Ranking se nulo
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo ?? true)); // Definir valor de Ativo se nulo

        // Mapeamento para criação de Cliente (ClienteCreateDto -> Cliente)
        CreateMap<ClienteCreateDto, Cliente>()
            .ForMember(dest => dest.ClienteId, opt => opt.Ignore()) // Ignorar o ClienteId na criação
            .ForMember(dest => dest.Cpf, opt => opt.MapFrom(src => src.Cpf))
            .ForMember(dest => dest.Ranking, opt => opt.MapFrom(src => src.Ranking ?? 0)) // Definir valor padrão para Ranking se nulo
            .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo)) // Manter o valor de Ativo
            .ForMember(dest => dest.EnderecosClientes, opt => opt.MapFrom(src => src.EnderecosClientes)) // Mapear EnderecosClientes
            .ForMember(dest => dest.TelefonesClientes, opt => opt.MapFrom(src => src.TelefonesClientes)) // Mapear TelefonesClientes
            .ForMember(dest => dest.CartoesCreditoClientes, opt => opt.Ignore()); // Ignorar Cartões de Crédito (não obrigatório)

        // Mapeamento de Cliente para ClienteDto
        CreateMap<Cliente, ClienteDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClienteId)) // Consistência no nome do campo
            .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.Cpf));

        // Mapeamento de Cliente para ClienteCompletoDto (incluindo relacionamentos)
        CreateMap<Cliente, ClienteCompletoDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClienteId)) // Consistência no nome do campo
            .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.Cpf))
            .ForMember(dest => dest.Enderecos, opt => opt.MapFrom(src => src.EnderecosClientes)) // Relacionamento de Endereços
            .ForMember(dest => dest.Telefones, opt => opt.MapFrom(src => src.TelefonesClientes)) // Relacionamento de Telefones
            .ForMember(dest => dest.Cartoes, opt => opt.MapFrom(src => src.CartoesCreditoClientes)); // Relacionamento de Cartões de Crédito

        // Mapeamento de EnderecoClienteCreateDto para EnderecoCliente
        CreateMap<EnderecoClienteCreateDto, EnderecoCliente>()
            .ForMember(dest => dest.EnderecoId, opt => opt.Ignore()); // Ignorar o Id, pois é gerado automaticamente

        // Mapeamento de TelefoneClienteCreateDto para TelefoneCliente
        CreateMap<TelefoneClienteCreateDto, TelefoneCliente>()
            .ForMember(dest => dest.TelefoneId, opt => opt.Ignore()); // Ignorar o Id, pois é gerado automaticamente
    }
}
