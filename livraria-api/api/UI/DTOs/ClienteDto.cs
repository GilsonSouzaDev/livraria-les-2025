namespace livraria_api.api.UI.DTOs
{
    public class ClienteDto
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
    }

    public class ClienteUpdateDto
    {
        public string? CodigoCliente { get; set; }
        public string? Genero { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public int? Ranking { get; set; }
        public bool? Ativo { get; set; }
    }

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
