using livraria_api.api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria_api.api.Infraestructure.Data.Mappings;

public class CartaoCreditoClienteConfiguration : IEntityTypeConfiguration<CartaoCreditoCliente>
{
    public void Configure(EntityTypeBuilder<CartaoCreditoCliente> builder)
    {
        builder.ToTable("CartoesCreditoCliente");
        builder.HasKey(c => c.CartaoCreditoClienteId);

        // Relacionamento com Cliente (1:N)
        builder.HasOne(c => c.Cliente)
            .WithMany(cli => cli.CartoesCreditoClientes)
            .HasForeignKey(c => c.ClienteID)
            .OnDelete(DeleteBehavior.Cascade); // Importante: Mantém o comportamento ON DELETE CASCADE do seu SQL.

        // Relacionamento com BandeiraCartao
        builder.HasOne(c => c.Bandeira)
            .WithMany(b => b.CartoesCreditoClientes) // Use a propriedade de navegação, se você a adicionou em BandeiraCartao.
            .HasForeignKey(c => c.BandeiraID)
            .OnDelete(DeleteBehavior.Cascade); // Importante: Mantém o comportamento ON DELETE CASCADE.
        builder.Property(x => x.NumeroCartao).IsRequired();
        builder.Property(x => x.NomeNoCartao).IsRequired();
        builder.Property(x => x.CodigoSeguranca).IsRequired();


    }
}
