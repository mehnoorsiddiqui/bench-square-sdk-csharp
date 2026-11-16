using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-05-15/merchant-custom-attributes-api/retrieve-merchant-custom-attributeDefinition">RetrieveMerchantCustomAttributeDefinition</see> request.
/// </summary>
public record RetrieveMerchantCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The current version of the custom attribute definition, which is used for strongly consistent
    /// reads to guarantee that you receive the most up-to-date data. When included in the request,
    /// Square returns the specified version or a higher version if one exists. If the specified version
    /// is higher than the current version, Square returns a <c>BAD_REQUEST</c> error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
