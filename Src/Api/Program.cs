using Data.DB;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Connection String

builder.Services.AddDbContext<CepBrasilDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CepBrasil")));

#endregion

#region IOC

//Servicos
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<INeighborhoodService, NeighborhoodService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IStateService, StateService>();

//Repositorios
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<INeighborhoodRepository, NeighborhoodRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IStateRepository, StateRepository>();

#endregion

var app = builder.Build();

app.MapGet("/estado/", ([FromServices] IStateService stateService) => Results.Ok(stateService.SearchByState()));

app.MapGet("/cidade/{estadoID}", ([FromServices] ICityService cityService, int estadoID) => Results.Ok(cityService.SearchByState(estadoID)));
app.MapGet("/cidade/buscar/{uf}", ([FromServices] ICityService cityService, string uf) => Results.Ok(cityService.SearchByState(uf)));

app.MapGet("/bairro/{estadoID}/{cidadeID}", ([FromServices] INeighborhoodService neighborhoodService, int estadoID, int cidadeID) => Results.Ok(neighborhoodService.SearchByStateAndCity(estadoID, cidadeID)));
app.MapGet("/bairro/buscar/{uf}/{cidade}", ([FromServices] INeighborhoodService neighborhoodService, string uf, string cidade) => Results.Ok(neighborhoodService.SearchByStateAndCity(uf, cidade)));

app.MapGet("/endereco/buscar/{cep}", ([FromServices] IAddressService addressService, string cep) => Results.Ok(addressService.SearchByCep(cep)));
app.MapGet("/endereco/buscar/cep/{endereco}", ([FromServices] IAddressService addressService, string endereco) => Results.Ok(addressService.SearchByAddress(endereco)));

app.Run();
