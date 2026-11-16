using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an individual delete request in a <see href="https://developer.squareup.com/reference/square_2024-04-17/location-custom-attributes-api/bulk-delete-location-custom-attributes">BulkDeleteLocationCustomAttributes</see>
/// request. An individual request contains an optional ID of the associated custom attribute definition
/// and optional key of the associated custom attribute definition.
/// </summary>
public record BulkDeleteLocationCustomAttributesRequestLocationCustomAttributeDeleteRequest
{
    /// <summary>
    /// The key of the associated custom attribute definition.
    /// Represented as a qualified key if the requesting app is not the definition owner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [RegularExpression("^([a-zA-Z0-9_-]+:)?[a-zA-Z0-9_-]{1,60}$")]
    public string? Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
