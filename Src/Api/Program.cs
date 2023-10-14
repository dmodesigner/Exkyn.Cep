using Data.DB;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Services;
using Exkyn.Core.Helpers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler(app => app.Run(async context =>
    {
        var exception = context.Features.Get<IExceptionHandlerPathFeature>()?.Error;

        var response = new ReturnModel
        {
            Success = false,
            StatusCode = HttpStatusCode.InternalServerError,
            Message = "Parece que a API não respondeu como deveria. Por favor, tente novamente mais tarde."
        };

        if (exception is ArgumentException || exception is ArgumentNullException)
        {
            response.StatusCode = HttpStatusCode.BadRequest;
            response.Message = exception.Message;
        }
        else
            LogHelpers.Save("C:\\Temp\\CepBrasil\\", string.Format("Log de Erro em {0:yyyy-MM-dd}.txt", DateTime.Now), exception);

        await context.Response.WriteAsJsonAsync(response);
    }));
}

#region Endpoint da API

app.MapGet("/estado/", ([FromServices] IStateService stateService) => Results.Ok(stateService.SearchByState()));

app.MapGet("/cidade/{estadoID}", ([FromServices] ICityService cityService, int estadoID) => Results.Ok(cityService.SearchByState(estadoID)));
app.MapGet("/cidade/buscar/{uf}", ([FromServices] ICityService cityService, string uf) => Results.Ok(cityService.SearchByState(uf)));

app.MapGet("/bairro/{estadoID}/{cidadeID}", ([FromServices] INeighborhoodService neighborhoodService, int estadoID, int cidadeID) => Results.Ok(neighborhoodService.SearchByStateAndCity(estadoID, cidadeID)));
app.MapGet("/bairro/buscar/{uf}/{cidade}", ([FromServices] INeighborhoodService neighborhoodService, string uf, string cidade) => Results.Ok(neighborhoodService.SearchByStateAndCity(uf, cidade)));

app.MapGet("/endereco/buscar/{cep}", ([FromServices] IAddressService addressService, string cep) => Results.Ok(addressService.SearchByCep(cep)));
app.MapGet("/endereco/buscar/cep/{endereco}", ([FromServices] IAddressService addressService, string endereco) => Results.Ok(addressService.SearchByAddress(endereco)));

//Eliminar esse endpoint quando terminar os testes
app.MapGet("/erro", () =>
{
    throw new InvalidOperationException("Parece que a API não respondeu como deveria. Por favor, tente novamente mais tarde.");
});

#endregion

app.Run();