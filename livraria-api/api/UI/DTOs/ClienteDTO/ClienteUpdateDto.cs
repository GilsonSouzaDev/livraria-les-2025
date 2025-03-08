namespace livraria_api.api.UI.DTOs.ClienteDTO
{
    public class ClienteUpdateDto
    {
        public string? CodigoCliente { get; set; } //Opcional, se esse campo puder ser atualizado
        public string? Genero { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? CPF { get; set; } //Opcional, se esse campo puder ser atualizado.
        public string? Email { get; set; }
        public int? Ranking { get; set; }
        public bool? Ativo { get; set; }
    }
}
