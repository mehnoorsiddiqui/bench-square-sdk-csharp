using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents information about the application used to generate a change.
/// </summary>
public record SourceApplication
{
    /// <summary>
    /// __Read only__ The <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/Product">product</see> type of the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product")]
    public string? Product { get; init; }

    /// <summary>
    /// __Read only__ The Square-assigned ID of the application. This field is used only if the
    /// <see href="https://developer.squareup.com/reference/square_2024-04-17/enums/Product">product</see> type is <c>EXTERNAL_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; init; }

    /// <summary>
    /// __Read only__ The display name of the application
    /// (for example, <c>"Custom Application"</c> or <c>"Square POS 4.74 for Android"</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
