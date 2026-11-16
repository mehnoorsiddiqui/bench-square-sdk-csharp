using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A request for a set of <c>WorkweekConfig</c> objects.
/// </summary>
public record ListWorkweekConfigsRequest
{
    /// <summary>
    /// The maximum number of <c>WorkweekConfigs</c> results to return per page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>WorkweekConfig</c> results to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
