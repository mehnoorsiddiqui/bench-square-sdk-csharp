using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents additional data for rules with the <c>VISIT</c> accrual type.
/// </summary>
public record LoyaltyProgramAccrualRuleVisitData
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minimum_amount_money")]
    public Money? MinimumAmountMoney { get; init; }

    /// <summary>
    /// Indicates how taxes should be treated when calculating the purchase amount to determine whether the visit qualifies for points.
    /// This setting applies only if <c>minimum_amount_money</c> is specified.
    /// </summary>
    [JsonPropertyName("tax_mode")]
    public required string TaxMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
