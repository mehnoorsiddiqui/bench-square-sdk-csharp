using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Information about a booking creator.
/// </summary>
public record BookingCreatorDetails
{
    /// <summary>
    /// The seller-accessible type of the creator of the booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator_type")]
    public string? CreatorType { get; init; }

    /// <summary>
    /// The ID of the team member who created the booking, when the booking creator is of the <c>TEAM_MEMBER</c> type.
    /// Access to this field requires seller-level permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [StringLength(32, MinimumLength = 0)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The ID of the customer who created the booking, when the booking creator is of the <c>CUSTOMER</c> type.
    /// Access to this field requires seller-level permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [StringLength(192, MinimumLength = 0)]
    public string? CustomerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
