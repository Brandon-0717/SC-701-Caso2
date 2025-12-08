using C2.Abstractions.BusinessLogic.Orden;
using C2.Abstractions.DataAccess.Orden;
using C2.BusinessLogic.Mapper;
using C2.BusinessLogic.Orden;
using C2.DataAccess;
using C2.DataAccess.Orden;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(cfg => { }, typeof(MapeoClases));

//INYECCION DE DEPENDENCIAS
#region Inyeccion de Dependencias
builder.Services.AddTransient<IOrdenRepositoryDA,OrdenRepositoryDA>();
builder.Services.AddTransient<IOrdenRepositoryBL, OrdenRepositoryBL>();
#endregion

// CONECTION STRING
var connectionString = builder.Configuration.GetConnectionString("SC701_CASO2-CONNSTRING") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
