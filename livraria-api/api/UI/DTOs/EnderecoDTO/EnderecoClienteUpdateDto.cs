namespace livraria_api.api.UI.DTOs.EnderecoDTO
{
    public class EnderecoClienteUpdateDto
    {
        public string? NomeEndereco { get; set; }
        public string? TipoResidencia { get; set; }
        public string? TipoLogradouro { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
        public string? Observacoes { get; set; }
        public bool? UsoCobranca { get; set; }
    }
}
