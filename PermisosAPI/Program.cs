using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PermisosAPI;
using PermisosAPI.EndPoints;
using PermisosAPI.Repositorios;

var builder = WebApplication.CreateBuilder(args);
//var origenesPermitidos = new[] { "http://localhost:5173" };
var origenesPermitidos =  builder.Configuration.GetValue<string>("origenesPermitidos")!;

builder.Services.AddCors(opciones=>
opciones.AddDefaultPolicy(configuracion=>
{
    configuracion.WithOrigins(origenesPermitidos).AllowAnyHeader().AllowAnyMethod();
}));

//Cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Servicios
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
opciones.UseSqlServer("name=DefaultConnection"));
//Importante en este orden...
builder.Services.AddOutputCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Servicios de Repositorios
builder.Services.AddScoped<IRepositorioPermisos, RepositorioPermisos>();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();
//middlewares
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/index", () => "Hello World! origenes permitidos: "+origenesPermitidos);
app.UseCors(); //Restringir origenes siguientes
//Endpoints con MapGroup
app.MapGroup("/api/permisos").MapPermisos();


app.Run();
