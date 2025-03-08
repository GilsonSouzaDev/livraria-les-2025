using livraria_api.api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c => c.ClienteId);
        builder.Property(c => c.CodigoCliente).IsRequired().HasMaxLength(20);
        builder.HasIndex(c => c.CodigoCliente).IsUnique(); // Mantém a unicidade.
        builder.Property(c => c.Genero).IsRequired().HasMaxLength(20);
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(255);
        builder.Property(c => c.DataNascimento).IsRequired();
        builder.Property(c => c.Cpf).IsRequired().HasMaxLength(14);
        builder.HasIndex(c => c.Cpf).IsUnique(); // Mantém a unicidade.
        builder.Property(c => c.Email).IsRequired().HasMaxLength(255);
        builder.HasIndex(c => c.Email);
        builder.Property(c => c.Ranking).IsRequired(false); // Permite nulos.
        builder.Property(c => c.Ativo).IsRequired().HasDefaultValue(true);

        // Relacionamento com Cartoes (1:N) - Já está configurado em CartaoCreditoClienteConfiguration, mas é bom ter aqui também para consistência.
        builder.HasMany(c => c.CartoesCreditoClientes)
               .WithOne(c => c.Cliente)
               .HasForeignKey(c => c.ClienteID)
               .OnDelete(DeleteBehavior.Cascade); //Configurado no seu script, importante manter

        builder.HasMany(c => c.EnderecosClientes)
               .WithOne(c => c.Cliente)
               .HasForeignKey(c => c.ClienteId)
               .OnDelete(DeleteBehavior.Cascade); //Configurado no seu script, importante manter

        builder.HasMany(c => c.TelefonesClientes)
               .WithOne(c => c.Cliente)
               .HasForeignKey(c => c.ClienteId)
               .OnDelete(DeleteBehavior.Cascade); //Configurado no seu script, importante manter
    }
}

