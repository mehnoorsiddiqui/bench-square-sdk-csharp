using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>DEACTIVATE</c> <see href="$m/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityDeactivate
{
    /// <summary>
    /// Indicates the reason for deactivating a <see href="$m/GiftCard">gift card</see>.
    /// </summary>
    [JsonPropertyName("reason")]
    public required GiftCardActivityDeactivateReason Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
