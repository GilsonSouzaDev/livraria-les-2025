using livraria.api.Infraestructure.Business.Strategies.CartaoCreditoClienteStrategies;
using livraria_api.api.Application.Facades;
using livraria_api.api.Domain.Interfaces.IFacades;
using livraria_api.api.Domain.Interfaces.IRepositorys;
using livraria_api.api.Domain.Interfaces.IStrategies;
using livraria_api.api.Domain.Models;
using livraria_api.api.Infraestructure.Business.Strategies.ClienteStrategies;
using livraria_api.api.Infraestructure.Data.Context;
using livraria_api.api.Infraestructure.Data.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbLivrariaContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 31))));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IStrategieBase<CartaoCreditoCliente>, ProcessarPreferencia>();

builder.Services.AddScoped<IStrategieBase<Cliente>, ProcessarObrigatoriedadeEndereco>();
builder.Services.AddScoped<IStrategieBase<Cliente>, ProcessarObrigatoriedadeCobranca>();


builder.Services.AddScoped<ICartaoCreditoClienteFacade, CartaoCreditoClienteFacade>();
builder.Services.AddScoped<IClienteFacade, ClienteFacade>();
builder.Services.AddScoped<IEnderecoClienteFacade, EnderecoClienteFacade>();
builder.Services.AddScoped<ITelefoneClienteFacade, TelefoneClienteFacade>();


builder.Services.AddScoped<ICartaoCreditoClienteRepository, CartaoCreditoClienteRepository>();
builder.Services.AddScoped<IEnderecoClienteRepository, EnderecoClienteRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ITelefoneClienteRepository, TelefoneClienteRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(o =>
{
    o.AllowAnyHeader();
    o.AllowAnyMethod();
    o.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
