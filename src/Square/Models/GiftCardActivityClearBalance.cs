using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>CLEAR_BALANCE</c> <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityClearBalance
{
    /// <summary>
    /// The reason the gift card balance was cleared.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
