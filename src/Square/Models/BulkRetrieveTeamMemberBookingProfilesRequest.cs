using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Request payload for the <see href="https://developer.squareup.com/reference/square_2024-08-21/bookings-api/bulk-retrieve-team-member-booking-profiles">BulkRetrieveTeamMemberBookingProfiles</see> endpoint.
/// </summary>
public record BulkRetrieveTeamMemberBookingProfilesRequest
{
    /// <summary>
    /// A non-empty list of IDs of team members whose booking profiles you want to retrieve.
    /// </summary>
    [JsonPropertyName("team_member_ids")]
    public required IReadOnlyList<string> TeamMemberIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
