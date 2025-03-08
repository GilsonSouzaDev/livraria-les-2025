namespace livraria_api.api.UI.DTOs.TelefoneDTO
{
    public class TelefoneClienteDto
    {
        public int Id { get; set; }
        public int ClienteID { get; set; } // Mantenha o ClienteID
        public string TipoTelefone { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
    }
}