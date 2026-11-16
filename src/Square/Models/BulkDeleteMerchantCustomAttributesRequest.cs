using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-04-17/merchant-custom-attributes-api/bulk-delete-merchant-custom-attributes">BulkDeleteMerchantCustomAttributes</see> request.
/// </summary>
public record BulkDeleteMerchantCustomAttributesRequest
{
    /// <summary>
    /// The data used to update the <c>CustomAttribute</c> objects.
    /// The keys must be unique and are used to map to the corresponding response.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkDeleteMerchantCustomAttributesRequestMerchantCustomAttributeDeleteRequest> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
