using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="https://developer.squareup.com/reference/square_2024-08-21/vendors-api/bulk-retrieve-vendors">BulkRetrieveVendors</see>.
/// </summary>
public record BulkRetrieveVendorsRequest
{
    /// <summary>
    /// IDs of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/Vendor">Vendor</see> objects to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor_ids")]
    public IReadOnlyList<string>? VendorIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
