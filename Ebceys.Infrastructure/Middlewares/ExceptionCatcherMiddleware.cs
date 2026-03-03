using Ebceys.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Ebceys.Infrastructure.Middlewares;

internal sealed class ExceptionCatcherMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await next.Invoke(httpContext);
        }
        catch (Exception ex) when (ex is not ApiException)
        {
            ApiExceptionHelper.ThrowException(ex);
        }
    }
}