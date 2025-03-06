
using System.Text.Json.Serialization;

namespace livraria_api.api.Domain.Models;

public class TelefoneCliente
{
    public int TelefoneId { get; set; }
    

    public int ClienteId { get; set; }

    public string TipoTelefone { get; set; } = null!;

    public string Ddd { get; set; } = null!;

    public string Numero { get; set; } = null!;

    [JsonIgnore]
    public virtual Cliente Cliente { get; set; } = null!;
}
