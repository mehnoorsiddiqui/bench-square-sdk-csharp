using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>CreateMobileAuthorizationCode</c> endpoint.
/// </summary>
public record CreateMobileAuthorizationCodeResponse
{
    /// <summary>
    /// The generated authorization code that connects a mobile application instance
    /// to a Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_code")]
    [MaxLength(191)]
    public string? AuthorizationCode { get; init; }

    /// <summary>
    /// The timestamp when <c>authorization_code</c> expires, in
    /// <see href="https://tools.ietf.org/html/rfc3339">RFC 3339</see> format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
