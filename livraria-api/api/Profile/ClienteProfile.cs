// Profiles/ClienteProfile.cs
using AutoMapper;
using livraria_api.api.Domain.Models;
using livraria_api.api.UI.DTOs.ClienteDTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace livraria_api.api.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        // ... (outros mapeamentos, como Cliente <-> ClienteDto) ...

        // Mapeamento para criação (ClienteCreateDto -> Cliente):
        CreateMap<ClienteCreateDto, Cliente>()
            .ForMember(dest => dest.ClienteId, opt => opt.Ignore())
            .ForMember(dest => dest.EnderecosClientes, opt => opt.MapFrom(src => src.EnderecosClientes))
            .ForMember(dest => dest.TelefonesClientes, opt => opt.MapFrom(src => src.TelefonesClientes));
                                                                                         
    }
}