using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a response from a retrieve request containing the specified <c>WageSetting</c> object or error messages.
/// </summary>
public record RetrieveWageSettingResponse
{
    /// <summary>
    /// An object representing a team member's wage information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage_setting")]
    public WageSetting? WageSetting { get; init; }

    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
