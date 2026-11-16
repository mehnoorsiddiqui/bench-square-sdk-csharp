using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// A request for a filtered set of <c>BreakType</c> objects.
/// </summary>
public record ListBreakTypesRequest
{
    /// <summary>
    /// Filter the returned <c>BreakType</c> results to only those that are associated with the
    /// specified location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The maximum number of <c>BreakType</c> results to return per page. The number can range between 1
    /// and 200. The default is 200.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }

    /// <summary>
    /// A pointer to the next page of <c>BreakType</c> results to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
