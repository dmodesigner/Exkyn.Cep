using Data.DB;
using Data.Repositories;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Services;
using Exkyn.Core.Helpers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

string? directoryLog = builder.Configuration.GetSection("Directory:Log").Value;
string? nameCors = "AccessToEveryone";

builder.Services.AddCors(options => options.AddPolicy(name: nameCors, b => b.WithOrigins("*")));

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

#region Configurações da cultura de idioma

var supportCulture = new[]
{
    new CultureInfo("pt-BR")
};

app.UseRequestLocalization(new RequestLocalizationOptions()
{
    DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("pt-BR"),
    SupportedCultures = supportCulture,
    SupportedUICultures = supportCulture
});

#endregion

#region Configurações para captura de erros

if (app.Environment.IsDevelopment())
	app.UseDeveloperExceptionPage();
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
            LogHelpers.Save(directoryLog, string.Format("Log de Erro em {0:yyyy-MM-dd}.txt", DateTime.Now), exception);

        await context.Response.WriteAsJsonAsync(response);
    }));
}

#endregion

#region Endpoint da API

app.MapGet("/estado/", ([FromServices] IStateService stateService) => Results.Ok(new ReturnModel<States>
{
    List = stateService.SearchByState()
}));

app.MapGet("/cidade/{estadoID}", ([FromServices] ICityService cityService, int estadoID) => Results.Ok(new ReturnModel<Cities>
{
    List = cityService.SearchByState(estadoID)
}));

app.MapGet("/cidade/buscar/{uf}", ([FromServices] ICityService cityService, string uf) => Results.Ok(new ReturnModel<Cities>
{
    List = cityService.SearchByState(uf)
}));

app.MapGet("/bairro/{estadoID}/{cidadeID}", ([FromServices] INeighborhoodService neighborhoodService, int estadoID, int cidadeID) => Results.Ok(new ReturnModel<Neighborhoods>
{
    List = neighborhoodService.SearchByStateAndCity(estadoID, cidadeID)
}));

app.MapGet("/bairro/buscar/{uf}/{cidade}", ([FromServices] INeighborhoodService neighborhoodService, string uf, string cidade) => Results.Ok(new ReturnModel<Neighborhoods>
{
    List = neighborhoodService.SearchByStateAndCity(uf, cidade)
}));

app.MapGet("/endereco/buscar/{cep}", ([FromServices] IAddressService addressService, string cep) => Results.Ok(new ReturnModel<ZipCodeModel>
{
    Object = addressService.SearchByCep(cep)
}));

app.MapGet("/endereco/buscar/cep/{endereco}", ([FromServices] IAddressService addressService, string endereco) => Results.Ok(new ReturnModel<ZipCodeModel>
{
    List = addressService.SearchByAddress(endereco)
}));

#endregion

app.UseCors(nameCors);
app.Run();