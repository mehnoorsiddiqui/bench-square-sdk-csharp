using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of discount the reward tier offers. DEPRECATED at version 2020-12-16. Discount details
/// are now defined using a catalog pricing rule and other catalog objects. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-rewards#get-discount-details">Getting discount details for a reward tier</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramRewardDefinitionType>))]
public sealed record LoyaltyProgramRewardDefinitionType : OpenStringEnum<LoyaltyProgramRewardDefinitionType>
{
    private LoyaltyProgramRewardDefinitionType(string value) : base(value)
    {
    }

    /// <summary>
    /// The fixed amount discounted.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionType FixedAmount = new("FIXED_AMOUNT");

    /// <summary>
    /// The fixed percentage discounted.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionType FixedPercentage = new("FIXED_PERCENTAGE");

    public TResult Match<TResult>(Func<TResult> onFixedAmount,
        Func<TResult> onFixedPercentage,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FixedAmount => onFixedAmount(),
            _ when this == FixedPercentage => onFixedPercentage(),
            _ => otherwise(Value)
        };

    public void Match(Action onFixedAmount, Action onFixedPercentage, Action<string> otherwise)
    {
        if (this == FixedAmount) onFixedAmount();
        else if (this == FixedPercentage) onFixedPercentage();
        else otherwise(Value);
    }
}
