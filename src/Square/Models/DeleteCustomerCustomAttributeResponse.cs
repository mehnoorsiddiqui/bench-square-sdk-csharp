using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-04-17/customer-custom-attributes-api/delete-customer-custom-attribute">DeleteCustomerCustomAttribute</see> response.
/// Either an empty object <c>{}</c> (for a successful deletion) or <c>errors</c> is present in the response.
/// </summary>
public record DeleteCustomerCustomAttributeResponse
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
