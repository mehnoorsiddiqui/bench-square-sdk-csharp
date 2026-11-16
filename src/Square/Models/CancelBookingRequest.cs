using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

public record CancelBookingRequest
{
    /// <summary>
    /// A unique key to make this request an idempotent operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [StringLength(255, MinimumLength = 0)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The revision number for the booking used for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_version")]
    [Minimum(0)]
    public int? BookingVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
