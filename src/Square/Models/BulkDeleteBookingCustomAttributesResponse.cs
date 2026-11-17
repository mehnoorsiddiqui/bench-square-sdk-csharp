using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-08-21/booking-custom-attributes-api/bulk-delete-booking-custom-attributes">BulkDeleteBookingCustomAttributes</see> response,
/// which contains a map of responses that each corresponds to an individual delete request.
/// </summary>
public record BulkDeleteBookingCustomAttributesResponse
{
    /// <summary>
    /// A map of responses that correspond to individual delete requests. Each response has the
    /// same ID as the corresponding request and contains <c>booking_id</c> and  <c>errors</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyDictionary<string, BookingCustomAttributeDeleteResponse>? Values { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
