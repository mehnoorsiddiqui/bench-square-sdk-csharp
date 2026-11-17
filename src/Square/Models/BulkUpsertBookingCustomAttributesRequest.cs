using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-08-21/booking-custom-attributes-api/bulk-upsert-booking-custom-attributes">BulkUpsertBookingCustomAttributes</see> request.
/// </summary>
public record BulkUpsertBookingCustomAttributesRequest
{
    /// <summary>
    /// A map containing 1 to 25 individual upsert requests. For each request, provide an
    /// arbitrary ID that is unique for this <c>BulkUpsertBookingCustomAttributes</c> request and the
    /// information needed to create or update a custom attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BookingCustomAttributeUpsertRequest> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
