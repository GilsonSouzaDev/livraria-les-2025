
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace livraria_api.api.Domain.Models;

public class CartaoCreditoCliente 
{
    public int CartaoCreditoClienteId { get; set; }

    public int ClienteID { get; set; }
    public int BandeiraID { get; set; }
    public string? NumeroCartao { get; set; }
    public string? NomeNoCartao { get; set; }
    public string? CodigoSeguranca { get; set; }
    public bool Preferencial { get; set; }

    // Propriedades de navegação (IMPORTANTES)

    [JsonIgnore]
    public Cliente? Cliente { get; set; }

    [JsonIgnore]
    public BandeiraCartao? Bandeira { get; set; }

}
