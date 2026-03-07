using JetBrains.Annotations;

namespace Ebceys.Infrastructure.HttpClient;

/// <summary>
///     The <see cref="ClientBaseUrlResolver" /> class.
/// </summary>
/// <param name="resolver"></param>
[PublicAPI]
public sealed class ClientBaseUrlResolver(Func<string> resolver) : IClientBaseResolver<string>
{
    /// <inheritdoc />
    public string Invoke()
    {
        return Invoker.Invoke();
    }

    /// <inheritdoc />
    public Func<string> Invoker { get; } = resolver;

    /// <summary>
    ///     Casts the <paramref name="resolver" /> to <see cref="ClientBaseUrlResolver" />.
    /// </summary>
    /// <param name="resolver">The resolver.</param>
    /// <returns>The new instance of <see cref="ClientBaseUrlResolver" />.</returns>
    public static implicit operator ClientBaseUrlResolver(Func<string> resolver)
    {
        return new ClientBaseUrlResolver(resolver);
    }

    /// <summary>
    ///     Creates the new instance of <see cref="ClientBaseUrlResolver" />.
    /// </summary>
    /// <param name="url">The url.</param>
    /// <returns>The new instance of <see cref="ClientBaseUrlResolver" />.</returns>
    public static ClientBaseUrlResolver Create(string url)
    {
        return new ClientBaseUrlResolver(() => url);
    }
}

/// <summary>
///     The <see cref="ClientBaseTokenResolver" /> class.
/// </summary>
/// <param name="resolver"></param>
[PublicAPI]
public sealed class ClientBaseTokenResolver(Func<Task<string?>>? resolver) : IClientBaseResolver<Task<string?>>
{
    /// <inheritdoc />
    public Task<string?> Invoke()
    {
        return Invoker?.Invoke() ?? Task.FromResult<string?>(null);
    }

    /// <inheritdoc />
    public Func<Task<string?>>? Invoker { get; } = resolver;

    /// <summary>
    ///     Casts the <paramref name="resolver" /> to <see cref="ClientBaseTokenResolver" />.
    /// </summary>
    /// <param name="resolver">The resolver.</param>
    /// <returns>The new instance of <see cref="ClientBaseTokenResolver" />.</returns>
    public static implicit operator ClientBaseTokenResolver(Func<Task<string?>>? resolver)
    {
        return new ClientBaseTokenResolver(resolver);
    }

    /// <summary>
    ///     Creates the new instance of <see cref="ClientBaseTokenResolver" />.
    /// </summary>
    /// <param name="token">The token.</param>
    /// <returns>The new instance of <see cref="ClientBaseTokenResolver" />.</returns>
    public static ClientBaseTokenResolver Create(string? token)
    {
        return new ClientBaseTokenResolver(() => Task.FromResult(token));
    }
}

/// <summary>
///     The <see cref="IClientBaseResolver{TResolve}" /> interface.
/// </summary>
/// <typeparam name="TResolve"></typeparam>
[PublicAPI]
public interface IClientBaseResolver<out TResolve>
{
    /// <summary>
    ///     The invoker.
    /// </summary>
    public Func<TResolve>? Invoker { get; }

    /// <summary>
    ///     Invokes the resolver.
    /// </summary>
    /// <returns></returns>
    public TResolve Invoke();
}