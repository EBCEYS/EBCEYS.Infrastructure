using JetBrains.Annotations;

namespace Ebceys.Infrastructure.Attributes;

/// <summary>
///     The <see cref="NoRequestBodyLoggingAttribute" /> class.
/// </summary>
/// <remarks>
///     Use it to hide request logging.
/// </remarks>
[PublicAPI]
[AttributeUsage(AttributeTargets.Method)]
public class NoRequestBodyLoggingAttribute : Attribute
{
}