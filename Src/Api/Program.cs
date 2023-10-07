using Data.DB;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Connection String

builder.Services.AddDbContext<CepBrasilDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings:CepBrasil")));

#endregion

#region IOC

//Servicos
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IStateService, StateService>();

//Repositorios
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IStateRepository, StateRepository>();

#endregion

var app = builder.Build();

app.MapGet("/buscar/endereco/{zipCode}", (string zipCode, [FromServices]IAddressService addressService) => addressService.SearchByCep(zipCode));

app.MapGet("/buscar/cep/{address}", (string address, [FromServices]IAddressService addressService) => addressService.SearchByAddress(address));

app.Run();
