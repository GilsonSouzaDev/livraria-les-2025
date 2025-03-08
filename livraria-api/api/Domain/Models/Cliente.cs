

namespace livraria_api.api.Domain.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    public string? CodigoCliente { get; set; }

    public string? Genero { get; set; }

    public string? Nome { get; set; }

    public DateTime DataNascimento { get; set; }

    public string? Cpf { get; set; }

    public string? Email { get; set; }

    public int? Ranking { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<CartaoCreditoCliente> CartoesCreditoClientes { get; set; } = new List<CartaoCreditoCliente>();

    public virtual ICollection<EnderecoCliente> EnderecosClientes { get; set; } = new List<EnderecoCliente>();

    public virtual ICollection<TelefoneCliente> TelefonesClientes { get; set; } = new List<TelefoneCliente>();
}
