

using Newtonsoft.Json;

namespace livraria_api.api.Domain.Models;

public class BandeiraCartao
{
    public int BandeiraId { get; set; }
   

    public string NomeBandeira { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<CartaoCreditoCliente> CartoesCreditoClientes { get; set; } = new List<CartaoCreditoCliente>();
    
}

