using livraria_api.api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class TelefoneClienteConfiguration : IEntityTypeConfiguration<TelefoneCliente>
{
    public void Configure(EntityTypeBuilder<TelefoneCliente> builder)
    {
        builder.ToTable("TelefonesCliente");
        builder.HasKey(x => x.TelefoneId);
        builder.HasOne(x => x.Cliente).WithMany(x => x.TelefonesClientes).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.Property(x => x.TipoTelefone).IsRequired();
        builder.Property(x => x.Ddd).IsRequired();
        builder.Property(x => x.Numero).IsRequired();
    }
}
