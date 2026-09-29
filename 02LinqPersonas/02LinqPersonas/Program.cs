using _02LinqPersonas.Models;
using _02LinqPersonas.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Inyección de la clase de repositorio concreta (Singleton para mantener los datos en memoria)
builder.Services.AddSingleton<ProvinciasEnRepositorio>();
builder.Services.AddSingleton<PersonasEnRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        // Le indicamos dónde está el archivo JSON generado por .NET
        options.SwaggerEndpoint("/openapi/v1.json", "Ejemplo API REST DAM v1");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
