using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Used *internally* to encapsulate pagination details. The resulting proto will be base62 encoded
/// in order to produce a cursor that can be used externally.
/// </summary>
public record PaginationCursor
{
    /// <summary>
    /// The ID of the last resource in the current page. The page can be in an ascending or
    /// descending order
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_value")]
    public string? OrderValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
