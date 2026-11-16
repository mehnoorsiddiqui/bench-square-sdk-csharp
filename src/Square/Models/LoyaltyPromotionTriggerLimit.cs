using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents the number of times a buyer can earn points during a <see href="https://developer.squareup.com/reference/square_2024-05-15/objects/LoyaltyPromotion">loyalty promotion</see>.
/// If this field is not set, buyers can trigger the promotion an unlimited number of times to earn points during
/// the time that the promotion is available.
/// <para>
/// A purchase that is disqualified from earning points because of this limit might qualify for another active promotion.
/// </para>
/// </summary>
public record LoyaltyPromotionTriggerLimit
{
    /// <summary>
    /// The maximum number of times a buyer can trigger the promotion during the specified <c>interval</c>.
    /// </summary>
    [JsonPropertyName("times")]
    [Minimum(1)]
    [Maximum(30)]
    public required int Times { get; init; }

    /// <summary>
    /// The time period the limit applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interval")]
    public string? Interval { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
