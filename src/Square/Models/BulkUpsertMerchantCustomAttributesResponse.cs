using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-05-15/merchant-custom-attributes-api/bulk-upsert-merchant-custom-attributes">BulkUpsertMerchantCustomAttributes</see> response,
/// which contains a map of responses that each corresponds to an individual upsert request.
/// </summary>
public record BulkUpsertMerchantCustomAttributesResponse
{
    /// <summary>
    /// A map of responses that correspond to individual upsert requests. Each response has the
    /// same ID as the corresponding request and contains either a <c>merchant_id</c> and <c>custom_attribute</c> or an <c>errors</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyDictionary<string, BulkUpsertMerchantCustomAttributesResponseMerchantCustomAttributeUpsertResponse>? Values { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
