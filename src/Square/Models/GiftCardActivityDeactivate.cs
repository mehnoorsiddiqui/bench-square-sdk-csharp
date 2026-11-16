using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>DEACTIVATE</c> <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityDeactivate
{
    /// <summary>
    /// The reason the gift card was deactivated.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
