namespace livraria_api.api.UI.DTOs.TelefoneDTO
{
    public class TelefoneClienteDto
    {
        public int Id { get; set; }
        public int ClienteID { get; set; } // Mantenha o ClienteID
        public string TipoTelefone { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
    }

    public class TelefoneClienteUpdateDto
    {
        public int Id { get; set; }
        public string? TipoTelefone { get; set; }
        public string? Ddd { get; set; }
        public string? Numero { get; set; }
    }

    public class TelefoneClienteCreateDto
    {
        public int ClienteID { get; set; } // Fundamental para o relacionamento.
        public string TipoTelefone { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
    }
}