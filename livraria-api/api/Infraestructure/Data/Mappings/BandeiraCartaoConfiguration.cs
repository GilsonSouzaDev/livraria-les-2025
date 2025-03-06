using livraria_api.api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria_api.api.Infraestructure.Data.Mappings;

public class BandeiraCartaoConfiguration : IEntityTypeConfiguration<BandeiraCartao>
{
    public void Configure(EntityTypeBuilder<BandeiraCartao> builder)
    {
        builder.ToTable("BandeirasCartao");
        builder.HasKey(b => b.BandeiraId);
        builder.Property(b => b.NomeBandeira).IsRequired().HasMaxLength(50); // Adicionado HasMaxLength para consistência.

        //Opcional: se quiser configurar o relacionamento do lado da Bandeira.
        builder.HasMany(b => b.CartoesCreditoClientes)
            .WithOne(c => c.Bandeira)
            .HasForeignKey(c => c.BandeiraID)
            .OnDelete(DeleteBehavior.Cascade); //Configurado no seu script, importante manter

    }
}