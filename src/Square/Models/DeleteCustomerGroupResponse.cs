using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2024-04-17/customer-groups-api/delete-customer-group">DeleteCustomerGroup</see> endpoint.
/// </summary>
public record DeleteCustomerGroupResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
