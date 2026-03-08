using System.Text.Json;
using System.Text.Json.Serialization;
using Flurl.Http.Configuration;
using JetBrains.Annotations;

namespace Ebceys.Infrastructure.Helpers.Json;

/// <summary>
///     The <see cref="DefaultJsonSerializerOptions" /> class.
/// </summary>
[PublicAPI]
public static class DefaultJsonSerializerOptions
{
    /// <summary>
    ///     The diagnostic JSON options.
    /// </summary>
    public static JsonSerializerOptions DiagnosticJsonOptions { get; } = new(JsonSerializerDefaults.Web)
    {
        Converters = { new JsonStringEnumConverter() },
        WriteIndented = true
    };

    /// <summary>
    ///     The default JSON options.
    /// </summary>
    public static JsonSerializerOptions DefaultJsonOptions { get; } = new(JsonSerializerDefaults.Web)
    {
        Converters = { new JsonStringEnumConverter() }
    };

    /// <summary>
    ///     The default JSON serializer.
    /// </summary>
    public static ISerializer DefaultJsonSerializer => new DefaultJsonSerializer(DefaultJsonOptions);
}