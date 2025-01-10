using Scalar.AspNetCore;
using apiCep.Services; // Certifique-se de ter o namespace correto para CepService

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddOpenApi(); // Generates OpenAPI documentation (v1.json)

// Register CepService for dependency injection
builder.Services.AddSingleton<CepService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enables detailed error pages in development
    app.MapOpenApi(); // Maps OpenAPI JSON and UI endpoints
    app.MapScalarApiReference(); // Maps Scalar API reference
}

app.UseHttpsRedirection(); // Redirects HTTP to HTTPS

app.UseAuthorization(); // Ensures authorization middleware is active

app.MapControllers(); // Maps routes to controllers

app.Run();
