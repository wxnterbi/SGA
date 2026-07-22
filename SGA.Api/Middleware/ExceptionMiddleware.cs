using System.Text.Json;
using SGA.Infrastructure.Logging;

namespace SGA.Api.Desktop.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ErrorLogger _errorLogger;

        public ExceptionMiddleware(RequestDelegate next, ErrorLogger errorLogger)
        {
            _next = next;
            _errorLogger = errorLogger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _errorLogger.LogError(ex);

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";

                var respuesta = new
                {
                    mensaje = "Ocurrió un error interno en el servidor."
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(respuesta));
            }
        }
    }
}
