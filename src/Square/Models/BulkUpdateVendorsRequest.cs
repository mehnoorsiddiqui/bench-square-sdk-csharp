using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="https://developer.squareup.com/reference/square_2024-05-15/vendors-api/bulk-update-vendors">BulkUpdateVendors</see>.
/// </summary>
public record BulkUpdateVendorsRequest
{
    /// <summary>
    /// A set of <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/UpdateVendorRequest">UpdateVendorRequest</see> objects encapsulating to-be-updated <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Vendor">Vendor</see>
    /// objects. The set is represented by  a collection of <c>Vendor</c>-ID/<c>UpdateVendorRequest</c>-object pairs.
    /// </summary>
    [JsonPropertyName("vendors")]
    public required IReadOnlyDictionary<string, UpdateVendorRequest> Vendors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
