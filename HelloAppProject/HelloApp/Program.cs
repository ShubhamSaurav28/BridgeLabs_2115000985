using BusinessLayer.Service;
using ModelLayer.DTO;
using RepositoryLayer.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<RegisterHelloBL>();
builder.Services.AddScoped<RegisterHelloRL>();
builder.Services.AddScoped<LoginDTO>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
