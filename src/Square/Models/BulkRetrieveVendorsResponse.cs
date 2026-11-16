using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="https://developer.squareup.com/reference/square_2024-04-17/vendors-api/bulk-retrieve-vendors">BulkRetrieveVendors</see>.
/// </summary>
public record BulkRetrieveVendorsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The set of <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/RetrieveVendorResponse">RetrieveVendorResponse</see> objects encapsulating successfully retrieved <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Vendor">Vendor</see>
    /// objects or error responses for failed attempts. The set is represented by
    /// a collection of <c>Vendor</c>-ID/<c>Vendor</c>-object or <c>Vendor</c>-ID/error-object pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, RetrieveVendorResponse>? Responses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
