using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a bulk update request for <c>TeamMember</c> objects.
/// </summary>
public record BulkUpdateTeamMembersRequest
{
    /// <summary>
    /// The data used to update the <c>TeamMember</c> objects. Each key is the <c>team_member_id</c> that maps to the <c>UpdateTeamMemberRequest</c>. The maximum number of update objects is 25.
    /// </summary>
    [JsonPropertyName("team_members")]
    public required IReadOnlyDictionary<string, UpdateTeamMemberRequest> TeamMembers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
