using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents how points for a <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyPromotion">loyalty promotion</see> are calculated,
/// either by multiplying the points earned from the base program or by adding a specified number
/// of points to the points earned from the base program.
/// </summary>
public record LoyaltyPromotionIncentive
{
    /// <summary>
    /// The type of points incentive.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Represents the metadata for a <c>POINTS_MULTIPLIER</c> type of <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyPromotionIncentive">loyalty promotion incentive</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points_multiplier_data")]
    public LoyaltyPromotionIncentivePointsMultiplierData? PointsMultiplierData { get; init; }

    /// <summary>
    /// Represents the metadata for a <c>POINTS_ADDITION</c> type of <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyPromotionIncentive">loyalty promotion incentive</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points_addition_data")]
    public LoyaltyPromotionIncentivePointsAdditionData? PointsAdditionData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
