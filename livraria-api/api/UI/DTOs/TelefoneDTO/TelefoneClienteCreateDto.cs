namespace livraria_api.api.UI.DTOs.TelefoneDTO
{
    public class TelefoneClienteCreateDto
    {
        public int ClienteID { get; set; } // Fundamental para o relacionamento.
        public string TipoTelefone { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
    }
}