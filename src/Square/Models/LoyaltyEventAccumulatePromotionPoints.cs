using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>ACCUMULATE_PROMOTION_POINTS</c>.
/// </summary>
public record LoyaltyEventAccumulatePromotionPoints
{
    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_program_id")]
    [MaxLength(36)]
    public string? LoyaltyProgramId { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/LoyaltyPromotion">loyalty promotion</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_promotion_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? LoyaltyPromotionId { get; init; }

    /// <summary>
    /// The number of points earned by the event.
    /// </summary>
    [JsonPropertyName("points")]
    public required int Points { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2024-04-17/objects/Order">order</see> for which the buyer earned the promotion points.
    /// Only applications that use the Orders API to process orders can trigger this event.
    /// </summary>
    [JsonPropertyName("order_id")]
    [MinLength(1)]
    public required string OrderId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
