using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="https://developer.squareup.com/reference/square_2024-05-15/customers-api/bulk-retrieve-customers">BulkRetrieveCustomers</see> endpoint.
/// </summary>
public record BulkRetrieveCustomersRequest
{
    /// <summary>
    /// The IDs of the <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/Customer">customer profiles</see> to retrieve.
    /// </summary>
    [JsonPropertyName("customer_ids")]
    public required IReadOnlyList<string> CustomerIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
