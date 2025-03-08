using livraria_api.api.UI.DTOs.EnderecoDTO;
using livraria_api.api.UI.DTOs.TelefoneDTO;

namespace livraria_api.api.UI.DTOs.ClienteDTO
{
    public class ClienteCreateDto
    {
        // Propriedades do Cliente (obrigatórias)
        public string CodigoCliente { get; set; }
        public string Genero { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int? Ranking { get; set; } // Opcional
        public bool Ativo { get; set; } // Opcional (pode ter um valor padrão)

        // *DTOs* dos relacionamentos obrigatórios (Endereços e Telefones)
        // Use *List* mesmo que você espere apenas um item.  Isso simplifica a validação.
        public List<EnderecoClienteCreateDto> EnderecosClientes { get; set; }
        public List<TelefoneClienteCreateDto> TelefonesClientes { get; set; }
        //Cartoes não é obrigatório.
    }
}
