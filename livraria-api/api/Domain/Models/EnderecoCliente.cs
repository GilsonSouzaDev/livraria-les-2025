

using System.Text.Json.Serialization;

namespace livraria_api.api.Domain.Models;

public class EnderecoCliente
{
    public int EnderecoId { get; set; }
   

    public int ClienteId { get; set; }

    public string NomeEndereco { get; set; } = null!;

    public string TipoResidencia { get; set; } = null!;

    public string TipoLogradouro { get; set; } = null!;

    public string Logradouro { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string? Observacoes { get; set; }

    public bool? UsoCobranca { get; set; }

    
    [JsonIgnore]
    public virtual Cliente Cliente { get; set; } = null!;
}

