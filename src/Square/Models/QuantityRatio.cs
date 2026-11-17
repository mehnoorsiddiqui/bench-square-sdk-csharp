using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A whole number or unreduced fractional ratio.
/// </summary>
public record QuantityRatio
{
    /// <summary>
    /// The whole or fractional quantity as the numerator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    /// The whole or fractional quantity as the denominator.
    /// With fractional quantity this field is the denominator and quantity is the numerator.
    /// The default value is <c>1</c>. For example, when <c>quantity=3</c> and <c>quantity_denominator</c> is unspecified,
    /// the quantity ratio is <c>3</c> or <c>3/1</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_denominator")]
    public int? QuantityDenominator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
