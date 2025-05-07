
using Domain.Models;
using Exkyn.Core.Helpers;
using System.Net;

namespace Api.Middleware;

public class ErrorHandlingMiddleware : IMiddleware
{
	private readonly string? _directoryLog;

	public ErrorHandlingMiddleware(string? directoryLog) => _directoryLog = directoryLog;

	private async Task HandleExceptionAsync(HttpContext context, Exception exception)
	{
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

			context.Response.StatusCode = StatusCodes.Status400BadRequest;
		}
		else
		{
			//Enviar o log de erro para o Seq
		}

		await context.Response.WriteAsJsonAsync(response);
	}

	public async Task InvokeAsync(HttpContext context, RequestDelegate next)
	{
		try
		{
			await next(context);
		}
		catch (Exception e)
		{
			await HandleExceptionAsync(context, e);
		}
	}
}
