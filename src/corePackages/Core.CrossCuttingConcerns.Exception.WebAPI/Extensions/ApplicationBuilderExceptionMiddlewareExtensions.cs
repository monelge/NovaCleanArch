using Microsoft.AspNetCore.Builder;
using Nova.Core.CrossCuttingConcerns.Exception.WebApi.Middleware;

namespace Nova.Core.CrossCuttingConcerns.Exception.WebApi.Extensions;

public static class ApplicationBuilderExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}
