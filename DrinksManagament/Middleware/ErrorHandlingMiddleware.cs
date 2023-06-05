using DrinksManagament.Contracts;
using DrinksManagament.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace DrinksManagament.Middleware
{
    public static class ErrorHandlingMiddleware
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Ha ocurrido un error: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetailsVM()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }
    }
}
