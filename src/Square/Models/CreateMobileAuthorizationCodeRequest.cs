using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be provided in a request to the
/// <c>CreateMobileAuthorizationCode</c> endpoint.
/// </summary>
public record CreateMobileAuthorizationCodeRequest
{
    /// <summary>
    /// The Square location ID that the authorization code should be tied to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(191, MinimumLength = 1)]
    public string? LocationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
