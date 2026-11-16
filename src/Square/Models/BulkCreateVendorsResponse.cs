using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="https://developer.squareup.com/reference/square_2024-05-15/vendors-api/bulk-create-vendors">BulkCreateVendors</see>.
/// </summary>
public record BulkCreateVendorsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A set of <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/CreateVendorResponse">CreateVendorResponse</see> objects encapsulating successfully created <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Vendor">Vendor</see>
    /// objects or error responses for failed attempts. The set is represented by
    /// a collection of idempotency-key/<c>Vendor</c>-object or idempotency-key/error-object pairs. The idempotency keys correspond to those specified
    /// in the input.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, CreateVendorResponse>? Responses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
