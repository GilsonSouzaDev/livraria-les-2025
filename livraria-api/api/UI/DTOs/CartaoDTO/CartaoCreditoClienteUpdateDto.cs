namespace livraria_api.api.UI.DTOs.CartaoDTO
{
    public class CartaoCreditoClienteUpdateDto
    {
        public int? BandeiraID { get; set; } //Pode ser null
        public string? NumeroCartao { get; set; } //Pode ser null
        public string? NomeNoCartao { get; set; } //Pode ser null
        public string? CodigoSeguranca { get; set; } //Pode ser null
        public bool? Preferencial { get; set; } //Pode ser null
    }
}
