using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

public record ListBookingsRequest
{
    /// <summary>
    /// The maximum number of results per page to return in a paged response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(10000)]
    public int? Limit { get; init; }

    /// <summary>
    /// The pagination cursor from the preceding response to return the next page of the results. Do not set this when retrieving the first page of the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(65536)]
    public string? Cursor { get; init; }

    /// <summary>
    /// The <see href="entity:Customer">customer</see> for whom to retrieve bookings. If this is not set, bookings for all customers are retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(192)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The team member for whom to retrieve bookings. If this is not set, bookings of all members are retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [MaxLength(32)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The location for which to retrieve bookings. If this is not set, all locations' bookings are retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(32)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the earliest of the start time. If this is not set, the current time is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at_min")]
    public string? StartAtMin { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the latest of the start time. If this is not set, the time of 31 days after <c>start_at_min</c> is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at_max")]
    public string? StartAtMax { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
