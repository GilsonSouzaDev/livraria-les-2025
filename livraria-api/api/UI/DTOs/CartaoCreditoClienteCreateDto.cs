namespace livraria_api.api.UI.DTOs
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

    public class CartaoCreditoClienteUpdateDto
    {
        public int? BandeiraID { get; set; } //Pode ser null
        public string? NumeroCartao { get; set; } //Pode ser null
        public string? NomeNoCartao { get; set; } //Pode ser null
        public string? CodigoSeguranca { get; set; } //Pode ser null
        public bool? Preferencial { get; set; } //Pode ser null
    }

}
