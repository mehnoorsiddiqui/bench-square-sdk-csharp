using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about an <c>UNBLOCK</c> <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityUnblock
{
    /// <summary>
    /// The reason the gift card was unblocked.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
