using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an individual delete response in a <see href="https://developer.squareup.com/reference/square_2024-08-21/merchant-custom-attributes-api/bulk-delete-merchant-custom-attributes">BulkDeleteMerchantCustomAttributes</see>
/// request.
/// </summary>
public record BulkDeleteMerchantCustomAttributesResponseMerchantCustomAttributeDeleteResponse
{
    /// <summary>
    /// Errors that occurred while processing the individual MerchantCustomAttributeDeleteRequest request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
