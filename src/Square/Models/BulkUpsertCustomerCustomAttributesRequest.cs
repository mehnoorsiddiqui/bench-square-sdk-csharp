using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-08-21/customer-custom-attributes-api/bulk-upsert-customer-custom-attributes">BulkUpsertCustomerCustomAttributes</see> request.
/// </summary>
public record BulkUpsertCustomerCustomAttributesRequest
{
    /// <summary>
    /// A map containing 1 to 25 individual upsert requests. For each request, provide an
    /// arbitrary ID that is unique for this <c>BulkUpsertCustomerCustomAttributes</c> request and the
    /// information needed to create or update a custom attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkUpsertCustomerCustomAttributesRequestCustomerCustomAttributeUpsertRequest> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
