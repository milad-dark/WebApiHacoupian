using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;

namespace WebApiHacoupian.Extention
{
    public static class ExceptionMiddlewareExtentions
    {
        public static void ConfigureBuildExeptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactury)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    var _logger = loggerFactury.CreateLogger("exceptionHandlerMidlleware");
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var contextRequest = context.Features.Get<IHttpRequestFeature>();

                    if (contextFeature != null)
                    {
                        string _error = $"[{context.Response.StatusCode}] - {contextFeature.Error.Message}: {contextRequest.Path}";

                        _logger.LogError(_error);

                        await context.Response.WriteAsync(_error);
                    }
                });
            });
        }
    }
}
