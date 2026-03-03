using Ebceys.Infrastructure.AuthorizationTestApplication.BoundedContext;
using Ebceys.Infrastructure.Exceptions;
using Ebceys.Infrastructure.HttpClient;
using Flurl.Http.Configuration;
using Microsoft.AspNetCore.Mvc;
using static Ebceys.Infrastructure.AuthorizationTestApplication.BoundedContext.RoutesDictionary.AuthControllerV1;

namespace Ebceys.Infrastructure.AuthorizationTestApplication.Client;

public interface IAuthAppClient
{
    Task<GenerateTokenResponse> GenerateTokenAsync(GenerateTokenRequest request,
        CancellationToken token = default);

    Task ValidateTokenAsync(CancellationToken token = default);

    Task ValidateAuthAsync(CancellationToken token = default);
}

public class AuthAppClient(
    IFlurlClientCache clientCache,
    ILoggerFactory loggerFactory,
    Func<string> baseUrlResolver,
    Func<Task<string>>? tokenResolver = null)
    : ClientBase(clientCache, loggerFactory, baseUrlResolver, tokenResolver), IAuthAppClient
{
    public async Task<GenerateTokenResponse> GenerateTokenAsync(GenerateTokenRequest request,
        CancellationToken token = default)
    {
        var response =
            await PostJsonAsync<GenerateTokenRequest, GenerateTokenResponse, ProblemDetails>(
                url => url.AppendPathSegments(
                    BaseRoute, Methods.GetToken),
                request,
                null,
                token);

        if (response is { IsSuccess: true, Result: not null })
        {
            return response.Result;
        }

        return ApiExceptionHelper.ThrowApiException(response);
    }

    public async Task ValidateTokenAsync(CancellationToken token = default)
    {
        var response = await PostAsync<ProblemDetails>(
            url => url.AppendPathSegments(BaseRoute, Methods.ValidateToken),
            token: token);

        if (!response.IsSuccess)
        {
            ApiExceptionHelper.ThrowApiException(response);
        }
    }

    public async Task ValidateAuthAsync(CancellationToken token = default)
    {
        var response = await GetAsync<ProblemDetails>(
            url => url.AppendPathSegments(BaseRoute, Methods.ValidateAuth), token: token);

        if (!response.IsSuccess)
        {
            ApiExceptionHelper.ThrowApiException(response);
        }
    }
}