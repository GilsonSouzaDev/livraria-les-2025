using livraria_api.api.UI.DTOs.CartaoDTO;
using livraria_api.api.UI.DTOs.EnderecoDTO;
using livraria_api.api.UI.DTOs.TelefoneDTO;

namespace livraria_api.api.UI.DTOs.ClienteDTO
{
    public class ClienteCompletoDto
    {
        public int Id { get; set; }
        public string CodigoCliente { get; set; }
        public string Genero { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int? Ranking { get; set; }
        public bool Ativo { get; set; }

        // Inclui *DTOs* dos relacionamentos:
        public List<EnderecoClienteDto> Enderecos { get; set; }
        public List<TelefoneClienteDto> Telefones { get; set; }
        public List<CartaoCreditoClienteDto> Cartoes { get; set; }
    }
}
