namespace livraria_api.api.UI.DTOs.CartaoDTO
{
    public class CartaoCreditoClienteCreateDto
    {
        public int ClienteID { get; set; }
        public int BandeiraID { get; set; }
        public string NumeroCartao { get; set; }
        public string NomeNoCartao { get; set; }
        public string CodigoSeguranca { get; set; }
        public bool Preferencial { get; set; }
    }
}
