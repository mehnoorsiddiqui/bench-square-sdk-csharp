using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-05-15/location-custom-attributes-api/bulk-delete-location-custom-attributes">BulkDeleteLocationCustomAttributes</see> response,
/// which contains a map of responses that each corresponds to an individual delete request.
/// </summary>
public record BulkDeleteLocationCustomAttributesResponse
{
    /// <summary>
    /// A map of responses that correspond to individual delete requests. Each response has the
    /// same key as the corresponding request.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkDeleteLocationCustomAttributesResponseLocationCustomAttributeDeleteResponse> Values { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
