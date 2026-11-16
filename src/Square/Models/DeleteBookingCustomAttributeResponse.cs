using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="https://developer.squareup.com/reference/square_2024-05-15/booking-custom-attributes-api/delete-booking-custom-attribute">DeleteBookingCustomAttribute</see> response.
/// Either an empty object <c>{}</c> (for a successful deletion) or <c>errors</c> is present in the response.
/// </summary>
public record DeleteBookingCustomAttributeResponse
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
