using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>ADJUST_POINTS</c>.
/// </summary>
public record LoyaltyEventAdjustPoints
{
    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2024-08-21/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_program_id")]
    [MaxLength(36)]
    public string? LoyaltyProgramId { get; init; }

    /// <summary>
    /// The number of points added or removed.
    /// </summary>
    [JsonPropertyName("points")]
    public required int Points { get; init; }

    /// <summary>
    /// The reason for the adjustment of points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
