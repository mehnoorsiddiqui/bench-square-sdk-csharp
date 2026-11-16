using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an update request for the <c>WageSetting</c> object describing a <c>TeamMember</c>.
/// </summary>
public record UpdateWageSettingRequest
{
    /// <summary>
    /// An object representing a team member's wage information.
    /// </summary>
    [JsonPropertyName("wage_setting")]
    public required WageSetting WageSetting { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
