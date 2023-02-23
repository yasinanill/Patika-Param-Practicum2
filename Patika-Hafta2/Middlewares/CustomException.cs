using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System;

namespace Patika_Hafta1_Odev.Middlewares
{
   
    private readonly ILoggerService _logger;

    public CustomExceptionMiddleware(RequestDelegate next, ILoggerService loggerService)
    {
        this.next = next;
        this._logger = loggerService;
    }

    public async Task Invoke(HttpContext context)
    {
        var watch = Stopwatch.StartNew();
        try
        {
            string message = "[Request]  HTTP " + context.Request.Method + " - " + context.Request.Path;
            _logger.Write(message);
            await next(context);
            watch.Stop();
            message = "[Response] HTTP " + context.Request.Method + " - " + context.Request.Path + " responded " + context.Response.StatusCode + " in " + watch.Elapsed.TotalMilliseconds + " ms";
            _logger.Write(message);
        }
        catch (Exception ex)
        {
            watch.Stop();
            await HandleException(context, ex, watch);
        }

    }

    private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        string message = "[Error]    HTTP " + context.Request.Method + " - " + context.Response.StatusCode + " Error Message: " + ex.Message + " in " + watch.Elapsed.TotalMilliseconds + " ms";
        _logger.Write(message);

        var result = JsonConvert.SerializeObject(new ServiceResponse<Exception> { Error = ex.Message, Success = false, Data = default(Exception) }, Formatting.None);

        return context.Response.WriteAsync(result);
    }
}
