using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="https://developer.squareup.com/reference/square_2024-04-17/customers-api/bulk-delete-customers">BulkDeleteCustomers</see> endpoint.
/// </summary>
public record BulkDeleteCustomersRequest
{
    /// <summary>
    /// The IDs of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Customer">customer profiles</see> to delete.
    /// </summary>
    [JsonPropertyName("customer_ids")]
    public required IReadOnlyList<string> CustomerIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
