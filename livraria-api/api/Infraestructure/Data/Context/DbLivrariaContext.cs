using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;


namespace livraria_api.api.Infraestructure.Data.Context;


    public partial class DbLivrariaContext : DbContext
    {
        public DbLivrariaContext()
        {
        }

        public DbLivrariaContext(DbContextOptions<DbLivrariaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EnderecoCliente> EnderecosClientes { get; set; }
        public DbSet<TelefoneCliente> TelefonesClientes { get; set; }
        public DbSet<CartaoCreditoCliente> CartoesCreditoClientes { get; set; }
        public DbSet<BandeiraCartao> BandeirasCartoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // Aplica as configurações das entidades.  Muito mais limpo!
            modelBuilder.ApplyConfiguration(new BandeiraCartaoConfiguration());
            modelBuilder.ApplyConfiguration(new CartaoCreditoClienteConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoClienteConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneClienteConfiguration());

            OnModelCreatingPartial(modelBuilder); // Mantém a chamada para o método parcial.
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

