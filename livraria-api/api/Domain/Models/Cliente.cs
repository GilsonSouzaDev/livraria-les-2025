

namespace livraria_api.api.Domain.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    

    public string CodigoCliente { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public DateTime DataNascimento { get; set; }

    public string Cpf { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Ranking { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<CartaoCreditoCliente> CartoesCreditoClientes { get; set; } = new List<CartaoCreditoCliente>();

    public virtual ICollection<EnderecoCliente> EnderecosClientes { get; set; } = new List<EnderecoCliente>();

    public virtual ICollection<TelefoneCliente> TelefonesClientes { get; set; } = new List<TelefoneCliente>();
}
