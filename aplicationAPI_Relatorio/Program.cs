using aplicationAPI_Relatorio.Data;
using Microsoft.EntityFrameworkCore;
using aplicationAPI_Relatorio.Repositories;
using aplicationAPI_Relatorio.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var teste = builder.Configuration.GetConnectionString("DataBase");
builder.Services
    .AddDbContext<SistemaContaBuscaDBContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))

        );

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IContaRepositorio, ContaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
