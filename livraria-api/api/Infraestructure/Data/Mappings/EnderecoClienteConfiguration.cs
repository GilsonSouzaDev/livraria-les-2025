using livraria_api.api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class EnderecoClienteConfiguration : IEntityTypeConfiguration<EnderecoCliente>
{
    public void Configure(EntityTypeBuilder<EnderecoCliente> builder)
    {
        builder.ToTable("EnderecosCliente");
        builder.HasKey(x => x.EnderecoId);
        builder.HasOne(x => x.Cliente).WithMany(x => x.EnderecosClientes).HasForeignKey(x => x.ClienteId).OnDelete(DeleteBehavior.Cascade);
        builder.Property(x => x.NomeEndereco).IsRequired();
        builder.Property(x => x.TipoResidencia).IsRequired();
        builder.Property(x => x.TipoLogradouro).IsRequired();
        builder.Property(x => x.Logradouro).IsRequired();
        builder.Property(x => x.Numero).IsRequired();
        builder.Property(x => x.Bairro).IsRequired();
        builder.Property(x => x.Cep).IsRequired();
        builder.Property(x => x.Cidade).IsRequired();
        builder.Property(x => x.Estado).IsRequired();
        builder.Property(x => x.Pais).IsRequired();
        builder.Property(x => x.Observacoes);
        builder.Property(x => x.UsoCobranca).IsRequired(false);

    }
}

