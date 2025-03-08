namespace livraria_api.api.UI.DTOs.CartaoDTO
{
    public class CartaoCreditoClienteDto
    {
        public int Id { get; set; }
        public int ClienteID { get; set; } // Mantenha o ClienteID
        public int BandeiraID { get; set; } // Mantenha o BandeiraID
        public string NumeroCartao { get; set; }
        public string NomeNoCartao { get; set; }
        public string CodigoSeguranca { get; set; }
        public bool Preferencial { get; set; }
        public BandeiraCartaoDto Bandeira { get; set; } // DTO da Bandeira
    }
}
