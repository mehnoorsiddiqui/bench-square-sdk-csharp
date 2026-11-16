using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

public record ListCashDrawerShiftEventsRequest
{
    /// <summary>
    /// The ID of the location to list cash drawer shifts for.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// Number of resources to be returned in a page of results (200 by
    /// default, 1000 max).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Maximum(1000)]
    public int? Limit { get; init; }

    /// <summary>
    /// Opaque cursor for fetching the next page of results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
