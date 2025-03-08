namespace livraria_api.api.UI.DTOs.ClienteDTO
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
}
