using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

public record ListTeamMemberBookingProfilesRequest
{
    /// <summary>
    /// Indicates whether to include only bookable team members in the returned result (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookable_only")]
    public bool? BookableOnly { get; init; }

    /// <summary>
    /// The maximum number of results to return in a paged response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [StringLength(65536, MinimumLength = 0)]
    public string? Cursor { get; init; }

    /// <summary>
    /// Indicates whether to include only team members enabled at the given location in the returned result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(32, MinimumLength = 0)]
    public string? LocationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
