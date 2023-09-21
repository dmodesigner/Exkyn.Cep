using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;

var builder = WebApplication.CreateBuilder(args);

#region IOC

//Servicos
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IStateService, StateService>();

//Repositorios

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IStateRepository, StateRepository>();

#endregion

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
