using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The booking profile of a seller's team member, including the team member's ID, display name, description and whether the team member can be booked as a service provider.
/// </summary>
public record TeamMemberBookingProfile
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/TeamMember">TeamMember</see> object for the team member associated with the booking profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [StringLength(32, MinimumLength = 0)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The description of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(65536, MinimumLength = 0)]
    public string? Description { get; init; }

    /// <summary>
    /// The display name of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [StringLength(512, MinimumLength = 0)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Indicates whether the team member can be booked through the Bookings API or the seller's online booking channel or site (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_bookable")]
    public bool? IsBookable { get; init; }

    /// <summary>
    /// The URL of the team member's image for the bookings profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile_image_url")]
    [StringLength(2048, MinimumLength = 0)]
    public string? ProfileImageUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
