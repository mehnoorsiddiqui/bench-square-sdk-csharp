using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Response payload for the <see href="https://developer.squareup.com/reference/square_2024-05-15/bookings-api/bulk-retrieve-team-member-booking-profiles">BulkRetrieveTeamMemberBookingProfiles</see> endpoint.
/// </summary>
public record BulkRetrieveTeamMemberBookingProfilesResponse
{
    /// <summary>
    /// The returned team members' booking profiles, as a map with <c>team_member_id</c> as the key and <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/TeamMemberBookingProfile">TeamMemberBookingProfile</see> the value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_booking_profiles")]
    public IReadOnlyDictionary<string, RetrieveTeamMemberBookingProfileResponse>? TeamMemberBookingProfiles { get; init; }

    /// <summary>
    /// Errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
